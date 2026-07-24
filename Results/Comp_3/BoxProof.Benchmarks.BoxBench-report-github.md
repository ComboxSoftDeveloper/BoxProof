```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5256)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method           | Job       | Runtime   | Size   | Hit   | Mean        | Error    | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |---------- |---------- |------- |------ |------------:|---------:|----------:|------:|--------:|----------:|------------:|
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **16**     | **False** |    **684.2 ns** |  **6.10 ns** |   **5.71 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 16     | False |  6,386.4 ns | 55.69 ns |  46.51 ns |  9.33 |    0.10 |    8192 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 16     | False |  2,084.8 ns |  9.99 ns |   9.35 ns |  3.05 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 16     | False |  1,754.5 ns |  4.36 ns |   3.87 ns |  2.56 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 16     | False |  1,166.3 ns |  5.74 ns |   5.37 ns |  1.70 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 16     | False |    682.2 ns |  2.18 ns |   2.04 ns |  1.00 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 16     | False |  1,199.5 ns |  4.29 ns |   4.01 ns |  1.75 |    0.02 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 16     | False |  1,893.9 ns |  5.04 ns |   4.47 ns |  2.77 |    0.02 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 16     | False |  1,138.6 ns |  5.25 ns |   4.65 ns |  1.66 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 16     | False |  6,399.3 ns | 32.73 ns |  27.33 ns |  9.35 |    0.08 |    8192 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 16     | False |  2,190.5 ns |  8.73 ns |   8.17 ns |  3.20 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 16     | False |  2,101.9 ns |  8.00 ns |   7.48 ns |  3.07 |    0.03 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 16     | False |  1,135.3 ns |  5.01 ns |   4.68 ns |  1.66 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 16     | False |    741.2 ns |  2.39 ns |   2.12 ns |  1.08 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 16     | False |    944.3 ns |  4.83 ns |   4.29 ns |  1.38 |    0.01 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 16     | False |  2,737.9 ns | 26.98 ns |  25.24 ns |  4.00 |    0.05 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 16     | False |  1,174.9 ns |  4.82 ns |   4.28 ns |  1.72 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 16     | False |  7,486.7 ns | 43.14 ns |  40.35 ns | 10.94 |    0.10 |    8192 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 16     | False |  1,914.7 ns | 21.48 ns |  20.09 ns |  2.80 |    0.04 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 16     | False |  1,882.1 ns | 25.15 ns |  23.53 ns |  2.75 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 16     | False |  1,010.3 ns |  3.40 ns |   3.02 ns |  1.48 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 16     | False |    724.8 ns |  3.63 ns |   3.40 ns |  1.06 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 16     | False |    973.4 ns |  3.17 ns |   2.81 ns |  1.42 |    0.01 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 16     | False |  2,597.5 ns | 32.00 ns |  29.93 ns |  3.80 |    0.05 |         - |          NA |
|                  |           |           |        |       |             |          |           |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **16**     | **True**  |    **787.6 ns** |  **1.59 ns** |   **1.41 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 16     | True  |  9,509.1 ns | 50.85 ns |  42.46 ns | 12.07 |    0.06 |   24576 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 16     | True  |  3,591.4 ns | 40.61 ns |  36.00 ns |  4.56 |    0.04 |    8192 B |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 16     | True  |  2,606.1 ns | 16.49 ns |  15.43 ns |  3.31 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 16     | True  |  1,276.3 ns |  4.89 ns |   4.58 ns |  1.62 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 16     | True  |    790.0 ns |  2.50 ns |   2.34 ns |  1.00 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 16     | True  |  1,384.5 ns |  5.57 ns |   4.94 ns |  1.76 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 16     | True  |  2,672.1 ns | 22.09 ns |  20.66 ns |  3.39 |    0.03 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 16     | True  |  1,247.5 ns | 17.23 ns |  16.12 ns |  1.58 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 16     | True  | 11,909.0 ns | 48.47 ns |  40.47 ns | 15.12 |    0.06 |   24576 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 16     | True  |  3,441.5 ns | 44.52 ns |  37.17 ns |  4.37 |    0.05 |    8192 B |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 16     | True  |  2,881.4 ns | 11.61 ns |  10.29 ns |  3.66 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 16     | True  |  1,390.3 ns |  4.06 ns |   3.80 ns |  1.77 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 16     | True  |    735.7 ns |  1.98 ns |   1.75 ns |  0.93 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 16     | True  |  1,321.6 ns |  3.81 ns |   3.57 ns |  1.68 |    0.01 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 16     | True  |  3,941.7 ns | 32.66 ns |  28.95 ns |  5.00 |    0.04 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 16     | True  |  1,147.8 ns | 16.95 ns |  15.85 ns |  1.46 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 16     | True  | 11,875.7 ns | 52.08 ns |  46.16 ns | 15.08 |    0.06 |   24576 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 16     | True  |  3,273.3 ns | 21.83 ns |  20.42 ns |  4.16 |    0.03 |    8192 B |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 16     | True  |  2,177.3 ns |  6.91 ns |   6.13 ns |  2.76 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 16     | True  |  1,127.9 ns |  5.47 ns |   5.12 ns |  1.43 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 16     | True  |    734.6 ns |  1.95 ns |   1.73 ns |  0.93 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 16     | True  |  1,401.8 ns |  2.55 ns |   2.13 ns |  1.78 |    0.00 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 16     | True  |  3,682.0 ns | 30.27 ns |  28.31 ns |  4.67 |    0.04 |         - |          NA |
|                  |           |           |        |       |             |          |           |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **1000**   | **False** |    **703.5 ns** | **11.03 ns** |  **10.32 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 1000   | False |  6,424.9 ns | 45.30 ns |  42.37 ns |  9.13 |    0.14 |    8192 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 1000   | False |  2,134.5 ns |  6.51 ns |   5.77 ns |  3.03 |    0.04 |         - |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 1000   | False |  1,871.6 ns | 14.08 ns |  13.17 ns |  2.66 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 1000   | False |  1,266.8 ns | 23.18 ns |  21.68 ns |  1.80 |    0.04 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 1000   | False |    694.3 ns |  2.58 ns |   2.15 ns |  0.99 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 1000   | False |  1,160.2 ns |  4.44 ns |   3.94 ns |  1.65 |    0.02 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 1000   | False |  1,979.7 ns |  6.33 ns |   5.61 ns |  2.81 |    0.04 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 1000   | False |  1,193.8 ns | 11.70 ns |  10.94 ns |  1.70 |    0.03 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 1000   | False |  6,864.0 ns | 33.73 ns |  26.34 ns |  9.76 |    0.14 |    8192 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 1000   | False |  2,140.3 ns |  6.95 ns |   6.16 ns |  3.04 |    0.04 |         - |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 1000   | False |  2,100.8 ns |  6.90 ns |   6.12 ns |  2.99 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 1000   | False |  1,191.4 ns |  3.89 ns |   3.63 ns |  1.69 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 1000   | False |  1,069.2 ns | 20.72 ns |  21.28 ns |  1.52 |    0.04 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 1000   | False |    954.9 ns |  3.91 ns |   3.46 ns |  1.36 |    0.02 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 1000   | False |  2,807.8 ns | 10.18 ns |   9.53 ns |  3.99 |    0.06 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 1000   | False |  1,122.0 ns |  6.04 ns |   5.35 ns |  1.60 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 1000   | False |  8,416.1 ns | 81.21 ns |  75.96 ns | 11.97 |    0.20 |    8192 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 1000   | False |  1,885.3 ns | 21.08 ns |  19.71 ns |  2.68 |    0.05 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 1000   | False |  1,838.1 ns |  6.30 ns |   5.89 ns |  2.61 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 1000   | False |  1,065.4 ns |  2.43 ns |   2.15 ns |  1.51 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 1000   | False |    736.1 ns |  5.24 ns |   4.90 ns |  1.05 |    0.02 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 1000   | False |    995.7 ns |  9.05 ns |   8.02 ns |  1.42 |    0.02 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 1000   | False |  2,783.6 ns | 18.33 ns |  17.15 ns |  3.96 |    0.06 |         - |          NA |
|                  |           |           |        |       |             |          |           |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **1000**   | **True**  |    **788.9 ns** |  **1.61 ns** |   **1.43 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 1000   | True  | 10,602.8 ns | 61.06 ns |  47.67 ns | 13.44 |    0.06 |   24576 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 1000   | True  |  3,495.4 ns | 23.00 ns |  32.99 ns |  4.43 |    0.04 |    8192 B |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 1000   | True  |  2,432.0 ns |  6.77 ns |   6.00 ns |  3.08 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 1000   | True  |  1,408.1 ns |  5.26 ns |   4.66 ns |  1.79 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 1000   | True  |    800.1 ns | 10.00 ns |   9.36 ns |  1.01 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 1000   | True  |  1,510.5 ns |  4.15 ns |   3.47 ns |  1.91 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 1000   | True  |  3,044.1 ns | 10.82 ns |  10.12 ns |  3.86 |    0.01 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 1000   | True  |  1,194.9 ns |  6.20 ns |   5.80 ns |  1.51 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 1000   | True  | 12,285.3 ns | 84.45 ns | 112.74 ns | 15.57 |    0.14 |   24576 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 1000   | True  |  3,865.6 ns | 31.41 ns |  29.38 ns |  4.90 |    0.04 |    8192 B |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 1000   | True  |  2,807.1 ns |  6.10 ns |   5.41 ns |  3.56 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 1000   | True  |  1,547.6 ns |  8.98 ns |   8.40 ns |  1.96 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 1000   | True  |    735.7 ns |  1.70 ns |   1.51 ns |  0.93 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 1000   | True  |  1,469.4 ns |  2.44 ns |   2.16 ns |  1.86 |    0.00 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 1000   | True  |  5,589.9 ns | 29.97 ns |  28.03 ns |  7.09 |    0.04 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 1000   | True  |  1,155.6 ns |  6.44 ns |   6.02 ns |  1.46 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 1000   | True  | 12,489.2 ns | 65.37 ns |  57.95 ns | 15.83 |    0.08 |   24576 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 1000   | True  |  3,455.5 ns | 20.33 ns |  19.02 ns |  4.38 |    0.02 |    8192 B |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 1000   | True  |  2,365.6 ns |  4.57 ns |   4.05 ns |  3.00 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 1000   | True  |  1,233.3 ns |  3.93 ns |   3.68 ns |  1.56 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 1000   | True  |    738.2 ns |  1.30 ns |   1.16 ns |  0.94 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 1000   | True  |  1,346.5 ns |  3.83 ns |   3.39 ns |  1.71 |    0.01 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 1000   | True  |  3,976.1 ns |  8.37 ns |   7.82 ns |  5.04 |    0.01 |         - |          NA |
|                  |           |           |        |       |             |          |           |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **100000** | **False** |    **749.0 ns** |  **4.83 ns** |   **4.28 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 100000 | False |  7,606.5 ns | 42.31 ns |  37.50 ns | 10.16 |    0.07 |    8192 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 100000 | False |  2,500.0 ns |  8.52 ns |   7.56 ns |  3.34 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 100000 | False |  2,183.3 ns | 10.17 ns |   9.02 ns |  2.92 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 100000 | False |  1,127.2 ns |  5.29 ns |   4.95 ns |  1.50 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 100000 | False |    728.1 ns |  1.61 ns |   1.43 ns |  0.97 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 100000 | False |  1,490.8 ns |  2.22 ns |   1.73 ns |  1.99 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 100000 | False |  2,530.5 ns |  7.90 ns |   7.00 ns |  3.38 |    0.02 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 100000 | False |  1,215.9 ns |  8.23 ns |   7.70 ns |  1.62 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 100000 | False |  6,767.1 ns | 32.43 ns |  28.75 ns |  9.04 |    0.06 |    8192 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 100000 | False |  2,498.6 ns |  6.78 ns |   6.01 ns |  3.34 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 100000 | False |  2,550.3 ns |  7.65 ns |   6.78 ns |  3.41 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 100000 | False |  1,024.5 ns |  5.74 ns |   5.09 ns |  1.37 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 100000 | False |    831.0 ns |  5.61 ns |   5.25 ns |  1.11 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 100000 | False |  1,349.5 ns |  4.96 ns |   4.64 ns |  1.80 |    0.01 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 100000 | False |  3,394.9 ns |  8.94 ns |   8.36 ns |  4.53 |    0.03 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 100000 | False |  1,157.9 ns |  9.81 ns |   8.70 ns |  1.55 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 100000 | False | 11,579.3 ns | 48.20 ns |  40.25 ns | 15.46 |    0.10 |    8192 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 100000 | False |  2,855.0 ns |  5.49 ns |   4.59 ns |  3.81 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 100000 | False |  2,737.5 ns | 14.21 ns |  13.29 ns |  3.66 |    0.03 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 100000 | False |  1,569.0 ns | 22.79 ns |  21.32 ns |  2.09 |    0.03 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 100000 | False |  1,292.2 ns | 23.48 ns |  21.97 ns |  1.73 |    0.03 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 100000 | False |  1,753.8 ns |  6.59 ns |   6.16 ns |  2.34 |    0.02 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 100000 | False |  3,425.5 ns | 33.77 ns |  31.59 ns |  4.57 |    0.05 |         - |          NA |
|                  |           |           |        |       |             |          |           |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **100000** | **True**  |    **792.4 ns** |  **4.08 ns** |   **3.81 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 100000 | True  | 11,841.4 ns | 74.50 ns |  66.04 ns | 14.94 |    0.11 |   24576 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 100000 | True  |  4,669.3 ns | 42.84 ns |  40.08 ns |  5.89 |    0.06 |    8192 B |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 100000 | True  |  3,102.8 ns | 26.05 ns |  24.37 ns |  3.92 |    0.03 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 100000 | True  |  1,459.1 ns |  3.33 ns |   2.95 ns |  1.84 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 100000 | True  |    789.8 ns |  1.65 ns |   1.54 ns |  1.00 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 100000 | True  |  2,015.1 ns |  5.49 ns |   4.87 ns |  2.54 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 100000 | True  |  4,196.1 ns | 32.46 ns |  30.36 ns |  5.30 |    0.04 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 100000 | True  |  1,197.4 ns |  3.50 ns |   3.10 ns |  1.51 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 100000 | True  | 13,247.9 ns | 95.77 ns |  84.90 ns | 16.72 |    0.13 |   24576 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 100000 | True  |  4,855.7 ns | 58.71 ns |  54.92 ns |  6.13 |    0.07 |    8192 B |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 100000 | True  |  3,431.4 ns | 30.82 ns |  28.83 ns |  4.33 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 100000 | True  |  1,564.4 ns |  6.40 ns |   5.99 ns |  1.97 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 100000 | True  |    759.3 ns |  1.68 ns |   1.49 ns |  0.96 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 100000 | True  |  1,980.0 ns | 12.04 ns |  11.26 ns |  2.50 |    0.02 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 100000 | True  |  5,580.2 ns | 33.77 ns |  29.94 ns |  7.04 |    0.05 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 100000 | True  |  1,126.2 ns |  3.56 ns |   2.97 ns |  1.42 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 100000 | True  | 18,644.6 ns | 59.60 ns |  55.75 ns | 23.53 |    0.13 |   24576 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 100000 | True  |  5,213.1 ns | 43.86 ns |  36.63 ns |  6.58 |    0.05 |    8192 B |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 100000 | True  |  3,600.8 ns | 32.94 ns |  30.81 ns |  4.54 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 100000 | True  |  1,903.1 ns |  5.39 ns |   5.04 ns |  2.40 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 100000 | True  |  1,125.7 ns |  3.33 ns |   2.95 ns |  1.42 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 100000 | True  |  2,403.9 ns | 11.57 ns |  10.82 ns |  3.03 |    0.02 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 100000 | True  |  5,347.2 ns | 36.86 ns |  34.48 ns |  6.75 |    0.05 |         - |          NA |
