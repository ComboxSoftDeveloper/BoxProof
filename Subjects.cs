using System.Runtime.CompilerServices;
using BoxProof.Enums;
using BoxProof.Models;

namespace BoxProof;

/// <summary>
/// Скрытый боксинг ключей-структур в Dictionary.
///
/// Суть: если struct-ключ не реализует IEquatable&lt;T&gt;,
/// EqualityComparer&lt;T&gt;.Default использует ObjectEqualityComparer,
/// а тот зовёт ValueType.Equals(object) - и на каждое сравнение при
/// поиске боксит операнды. Колонка Allocated покажет это байтами.
///
/// Пруфы:
///   Выбор компаратора в EqualityComparer&lt;T&gt;.Default -
///       https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/EqualityComparer.cs
///   Выбор компаратора по интерфейсам типа (ComparerHelpers) -
///       https://github.com/dotnet/runtime/blob/main/src/coreclr/System.Private.CoreLib/src/System/Collections/Generic/ComparerHelpers.cs
///   ValueType.Equals в общем случае - рефлексия и боксинг -
///       https://github.com/dotnet/runtime/blob/main/src/coreclr/System.Private.CoreLib/src/System/ValueType.cs
///   FindValue, из которого сняты дизасм-листинги -
///       https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/Dictionary.cs
/// </summary>

public static class Subjects
{
    // Каждый метод - пачка TryGetValue по готовому словарю.
    // Возвращаем сумму найденного, чтобы JIT не выкинул вызовы.

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupPlain(Dictionary<PlainKey, int> dict, PlainKey[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupOverride(Dictionary<OverrideKey, int> dict, OverrideKey[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupEquatable(Dictionary<EquatableKey, int> dict, EquatableKey[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupCascade(Dictionary<CascadeKey, int> dict, CascadeKey[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupRecord(Dictionary<RecordKey, int> dict, RecordKey[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupEnum(Dictionary<EnumKey, int> dict, EnumKey[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupGuid(Dictionary<Guid, int> dict, Guid[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupInt(Dictionary<int, int> dict, int[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LookupString(Dictionary<string, int> dict, string[] keys)
    {
        int sum = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (dict.TryGetValue(keys[i], out int value))
            {
                sum += value;
            }
        }

        return sum;
    }
}
