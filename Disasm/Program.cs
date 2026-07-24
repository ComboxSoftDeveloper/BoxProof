using System.Runtime.Intrinsics.X86;
using BoxProof;

namespace Disasm;

/// <summary>
/// Паспорт железа + tiered-прогрев для снятия листингов.
/// Смотреть в дампе: Dictionary&lt;K,V&gt;.FindValue - у PlainKey/OverrideKey
/// внутри call на ValueType/Object.Equals, у EquatableKey/RecordKey/int -
/// инлайн сравнения. Метод печатается несколько раз - брать последний (Tier1).
/// </summary>
internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("=== Железо/рантайм ===");
        Console.WriteLine($"Avx2:     {Avx2.IsSupported}");
        Console.WriteLine($"Runtime:  {Environment.Version}");
        Console.WriteLine();

        const int size = 1_000;
        const int lookups = 256;

        Dictionary<PlainKey, int> plainDict = new(size);
        Dictionary<EquatableKey, int> eqDict = new(size);
        Dictionary<int, int> intDict = new(size);
        for (int i = 0; i < size; i++)
        {
            int v = i * 3;
            plainDict[new PlainKey { A = v, B = v + 1, C = v + 2 }] = v;
            eqDict[new EquatableKey { A = v, B = v + 1, C = v + 2 }] = v;
            intDict[v] = v;
        }

        PlainKey[] plainKeys = new PlainKey[lookups];
        EquatableKey[] eqKeys = new EquatableKey[lookups];
        int[] intKeys = new int[lookups];
        for (int i = 0; i < lookups; i++)
        {
            int v = i * 3 % (size * 3);
            plainKeys[i] = new PlainKey { A = v, B = v + 1, C = v + 2 };
            eqKeys[i] = new EquatableKey { A = v, B = v + 1, C = v + 2 };
            intKeys[i] = v;
        }

        long sink = 0;
        for (int i = 0; i < 200_000; i++)
        {
            sink += Subjects.LookupPlain(plainDict, plainKeys);
            sink += Subjects.LookupEquatable(eqDict, eqKeys);
            sink += Subjects.LookupInt(intDict, intKeys);
        }

        Console.WriteLine(sink);
    }
}
