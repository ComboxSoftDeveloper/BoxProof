using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BoxProof.Enums;
using BoxProof.Models;

namespace BoxProof.Benchmarks;

/// <summary>
/// Поиск в Dictionary по разным видам ключей: где боксинг, а где нет.
/// </summary>
[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0, baseline: true)]
public class BoxBench
{
    private const int LookupCount = 256;

    [Params(16, 1_000, 100_000)]
    public int Size { get; set; }

    [Params(true, false)]
    public bool Hit { get; set; }

    private Dictionary<PlainKey, int> _plainDict = null!;
    private Dictionary<OverrideKey, int> _overrideDict = null!;

    private Dictionary<EquatableKey, int> _equatableDict = null!;
    private Dictionary<RecordKey, int> _recordDict = null!;

    private Dictionary<EnumKey, int> _enumDict = null!;
    private Dictionary<Guid, int> _guidDict = null!;
    
    private Dictionary<int, int> _intDict = null!;
    private Dictionary<string, int> _stringDict = null!;

    private PlainKey[] _plainKeys = null!;
    private OverrideKey[] _overrideKeys = null!;
    
    private EquatableKey[] _equatableKeys = null!;
    private RecordKey[] _recordKeys = null!;

    private EnumKey[] _enumKeys = null!;
    private Guid[] _guidKeys = null!;
    
    private int[] _intKeys = null!;
    private string[] _stringKeys = null!;

    [GlobalSetup]
    public void Setup()
    {
        Guid[] allGuids = new Guid[Size];

        _plainDict = new Dictionary<PlainKey, int>(Size);
        _overrideDict = new Dictionary<OverrideKey, int>(Size);
        
        _equatableDict = new Dictionary<EquatableKey, int>(Size);
        _recordDict = new Dictionary<RecordKey, int>(Size);
        
        _enumDict = new Dictionary<EnumKey, int>(Size);
        _guidDict = new Dictionary<Guid, int>(Size);

        _intDict = new Dictionary<int, int>(Size);
        _stringDict = new Dictionary<string, int>(Size);

        for (int i = 0; i < Size; i++)
        {
            // в словаре только кратные 3 - для гарантированного miss
            int key = i * 3;
            
            allGuids[i] = Guid.NewGuid();

            _plainDict[new PlainKey
            {
                A = key,
                B = key + 1,
                C = key + 2
            }] = key;

            _overrideDict[new OverrideKey
            {
                A = key,
                B = key + 1,
                C = key + 2
            }] = key;

            _equatableDict[new EquatableKey
            {
                A = key,
                B = key + 1,
                C = key + 2
            }] = key;

            _recordDict[new RecordKey(key, key + 1, key + 2)] = key;
            
            _enumDict[(EnumKey)key] = key;
            _guidDict[allGuids[i]] = key;

            _intDict[key] = key;
            _stringDict["key_" + key] = key;
        }

        _plainKeys = new PlainKey[LookupCount];
        _overrideKeys = new OverrideKey[LookupCount];
        
        _equatableKeys = new EquatableKey[LookupCount];
        _recordKeys = new RecordKey[LookupCount];
        
        _enumKeys = new EnumKey[LookupCount];
        _guidKeys = new Guid[LookupCount];

        _intKeys = new int[LookupCount];
        _stringKeys = new string[LookupCount];

        for (int i = 0; i < LookupCount; i++)
        {
            // раскладка по всему словарю
            int key = i * 3 % (Size * 3);
            if (!Hit)
            {
                // кратность 3 нарушена - в словаре такого нет
                key += 1;
            }

            _plainKeys[i] = new PlainKey
            {
                A = key,
                B = key + 1,
                C = key + 2
            };

            _overrideKeys[i] = new OverrideKey
            {
                A = key,
                B = key + 1,
                C = key + 2
            };

            _equatableKeys[i] = new EquatableKey
            {
                A = key,
                B = key + 1,
                C = key + 2
            };
            
            _recordKeys[i] = new RecordKey(key, key + 1, key + 2);
            _enumKeys[i] = (EnumKey)key;
            
            _guidKeys[i] = Hit ? allGuids[key / 3] : Guid.NewGuid();
            _intKeys[i] = key;
            
            _stringKeys[i] = Hit ? "key_" + key : "key_" + key + "_miss";
        }

        int expected = Hit ? LookupCount : 0;

        Check(nameof(Subjects.LookupPlain), CountHits(_plainDict, _plainKeys) == expected);
        Check(nameof(Subjects.LookupOverride), CountHits(_overrideDict, _overrideKeys) == expected);
        
        Check(nameof(Subjects.LookupEquatable), CountHits(_equatableDict, _equatableKeys) == expected);
        Check(nameof(Subjects.LookupRecord), CountHits(_recordDict, _recordKeys) == expected);
        
        Check(nameof(Subjects.LookupEnum), CountHits(_enumDict, _enumKeys) == expected);
        Check(nameof(Subjects.LookupGuid), CountHits(_guidDict, _guidKeys) == expected);
        
        Check(nameof(Subjects.LookupInt), CountHits(_intDict, _intKeys) == expected);
        Check(nameof(Subjects.LookupString), CountHits(_stringDict, _stringKeys) == expected);
    }

    private static int CountHits<TKey>(Dictionary<TKey, int> dict, TKey[] keys) where TKey : notnull
    {
        int count = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.ContainsKey(keys[i]))
            {
                count++;
            }
        }

        return count;
    }

    private static void Check(string name, bool ok)
    {
        if (!ok)
        {
            throw new InvalidOperationException($"{name}: сверка Setup не сошлась");
        }
    }

    [Benchmark(Baseline = true)]
    public int Lookup_Int() => Subjects.LookupInt(_intDict, _intKeys);

    [Benchmark]
    public int Lookup_Plain() => Subjects.LookupPlain(_plainDict, _plainKeys);

    [Benchmark]
    public int Lookup_Override() => Subjects.LookupOverride(_overrideDict, _overrideKeys);

    [Benchmark]
    public int Lookup_Equatable() => Subjects.LookupEquatable(_equatableDict, _equatableKeys);

    [Benchmark]
    public int Lookup_Record() => Subjects.LookupRecord(_recordDict, _recordKeys);

    [Benchmark]
    public int Lookup_Enum() => Subjects.LookupEnum(_enumDict, _enumKeys);

    [Benchmark]
    public int Lookup_Guid() => Subjects.LookupGuid(_guidDict, _guidKeys);

    [Benchmark]
    public int Lookup_String() => Subjects.LookupString(_stringDict, _stringKeys);
}
