namespace BoxProof.Models;

// Правильный вариант: типизированное сравнение без боксинга.
public struct EquatableKey : IEquatable<EquatableKey>
{
    public int A;
    public int B;
    public int C;

    public bool Equals(EquatableKey other) => other.A == A && other.B == B && other.C == C;

    public override bool Equals(object? obj) => obj is EquatableKey other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(A, B, C);
}
