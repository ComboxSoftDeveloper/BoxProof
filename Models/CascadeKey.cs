namespace BoxProof.Models;

// Контрольный вариант: IEquatable + такой же хэш-каскад, как генерит
// компилятор для record. Если разница с RecordKey уходит - дело было
// в хэш-функции, а не в типе.
public struct CascadeKey : IEquatable<CascadeKey>
{
    public int A;
    public int B;
    public int C;

    public bool Equals(CascadeKey other) => other.A == A && other.B == B && other.C == C;

    public override bool Equals(object? obj) => obj is CascadeKey other && Equals(other);

    // Множитель из хэша, который компилятор генерит для record struct
    // (виден в декомпиле GetHashCode любого record).
    private const int RecordHashMultiplier = -1521134295;

    public override int GetHashCode()
    {
        int hash = EqualityComparer<int>.Default.GetHashCode(A);

        hash = hash * RecordHashMultiplier + EqualityComparer<int>.Default.GetHashCode(B);
        hash = hash * RecordHashMultiplier + EqualityComparer<int>.Default.GetHashCode(C);

        return hash;
    }
}
