namespace BoxProof.Models;

// Компилятор сам генерит IEquatable + Equals + GetHashCode.
public record struct RecordKey(int A, int B, int C);
