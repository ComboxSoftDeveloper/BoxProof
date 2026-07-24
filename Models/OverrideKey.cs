namespace BoxProof.Models;

// Override Equals/GetHashCode есть, IEquatable НЕТ - частый вариант:
// кажется, что этого достаточно. Equals(object) всё равно боксит аргумент.
public struct OverrideKey
{
    public int A;
    public int B;
    public int C;

    public override bool Equals(object? obj) => obj is OverrideKey other && other.A == A && other.B == B && other.C == C;

    public override int GetHashCode() => HashCode.Combine(A, B, C);
}
