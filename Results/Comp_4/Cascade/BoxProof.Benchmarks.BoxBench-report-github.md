```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method           | Job       | Runtime   | Size   | Hit   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |---------- |---------- |------- |------ |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **Lookup_Equatable** | **.NET 10.0** | **.NET 10.0** | **16**     | **False** | **1,576.4 ns** | **29.85 ns** | **26.46 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 16     | False | 1,717.5 ns | 20.15 ns | 17.86 ns |  1.09 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 16     | False | 1,328.2 ns | 25.96 ns | 29.89 ns |  0.84 |    0.02 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Cascade   | .NET 10.0 | .NET 10.0 | 16     | False | 1,011.3 ns | 19.77 ns | 25.71 ns |  1.00 |    0.04 |         - |          NA |
| Lookup_Cascade   | .NET 8.0  | .NET 8.0  | 16     | False |   946.6 ns | 15.58 ns | 14.57 ns |  0.94 |    0.03 |         - |          NA |
| Lookup_Cascade   | .NET 9.0  | .NET 9.0  | 16     | False |   906.2 ns | 17.43 ns | 19.38 ns |  0.90 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 16     | False | 1,140.6 ns | 16.69 ns | 15.61 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 16     | False | 1,029.2 ns | 14.91 ns | 13.22 ns |  0.90 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 16     | False | 1,086.2 ns | 19.10 ns | 16.93 ns |  0.95 |    0.02 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| **Lookup_Equatable** | **.NET 10.0** | **.NET 10.0** | **16**     | **True**  | **1,877.9 ns** | **30.56 ns** | **27.09 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 16     | True  | 2,275.6 ns | 42.04 ns | 39.33 ns |  1.21 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 16     | True  | 1,847.7 ns | 31.79 ns | 35.33 ns |  0.98 |    0.02 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Cascade   | .NET 10.0 | .NET 10.0 | 16     | True  | 1,171.7 ns | 19.99 ns | 24.55 ns |  1.00 |    0.03 |         - |          NA |
| Lookup_Cascade   | .NET 8.0  | .NET 8.0  | 16     | True  | 1,088.8 ns | 13.65 ns | 11.40 ns |  0.93 |    0.02 |         - |          NA |
| Lookup_Cascade   | .NET 9.0  | .NET 9.0  | 16     | True  | 1,046.4 ns | 20.31 ns | 23.39 ns |  0.89 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 16     | True  | 1,175.6 ns | 21.06 ns | 19.70 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 16     | True  | 1,198.9 ns | 20.37 ns | 19.06 ns |  1.02 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 16     | True  |   979.2 ns | 17.40 ns | 15.43 ns |  0.83 |    0.02 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| **Lookup_Equatable** | **.NET 10.0** | **.NET 10.0** | **1000**   | **False** | **1,600.6 ns** | **30.88 ns** | **33.05 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 1000   | False | 1,851.9 ns | 34.30 ns | 32.09 ns |  1.16 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 1000   | False | 1,553.3 ns | 30.35 ns | 32.47 ns |  0.97 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Cascade   | .NET 10.0 | .NET 10.0 | 1000   | False | 1,119.5 ns | 21.49 ns | 27.18 ns |  1.00 |    0.03 |         - |          NA |
| Lookup_Cascade   | .NET 8.0  | .NET 8.0  | 1000   | False | 1,088.9 ns | 21.26 ns | 29.80 ns |  0.97 |    0.03 |         - |          NA |
| Lookup_Cascade   | .NET 9.0  | .NET 9.0  | 1000   | False | 1,163.3 ns | 14.09 ns | 11.77 ns |  1.04 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 1000   | False | 1,214.1 ns | 16.63 ns | 14.74 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 1000   | False | 1,209.6 ns | 21.68 ns | 30.39 ns |  1.00 |    0.03 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 1000   | False | 1,281.3 ns | 24.51 ns | 27.24 ns |  1.06 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| **Lookup_Equatable** | **.NET 10.0** | **.NET 10.0** | **1000**   | **True**  | **2,066.9 ns** | **41.28 ns** | **42.40 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 1000   | True  | 2,566.0 ns | 48.16 ns | 42.69 ns |  1.24 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 1000   | True  | 2,017.0 ns | 15.81 ns | 13.21 ns |  0.98 |    0.02 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Cascade   | .NET 10.0 | .NET 10.0 | 1000   | True  | 1,400.0 ns | 14.10 ns | 13.19 ns |  1.00 |    0.01 |         - |          NA |
| Lookup_Cascade   | .NET 8.0  | .NET 8.0  | 1000   | True  | 1,338.2 ns | 22.15 ns | 19.63 ns |  0.96 |    0.02 |         - |          NA |
| Lookup_Cascade   | .NET 9.0  | .NET 9.0  | 1000   | True  | 1,222.0 ns | 23.73 ns | 21.04 ns |  0.87 |    0.02 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 1000   | True  | 1,393.7 ns | 23.52 ns | 22.00 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 1000   | True  | 1,385.4 ns | 20.60 ns | 19.27 ns |  0.99 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 1000   | True  | 1,200.7 ns | 24.03 ns | 30.38 ns |  0.86 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| **Lookup_Equatable** | **.NET 10.0** | **.NET 10.0** | **100000** | **False** | **2,256.4 ns** | **38.11 ns** | **33.78 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 100000 | False | 2,611.9 ns | 50.63 ns | 54.17 ns |  1.16 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 100000 | False | 3,094.0 ns | 61.03 ns | 79.35 ns |  1.37 |    0.04 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Cascade   | .NET 10.0 | .NET 10.0 | 100000 | False |   995.6 ns | 12.42 ns | 11.01 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Cascade   | .NET 8.0  | .NET 8.0  | 100000 | False |   945.8 ns | 14.40 ns | 12.76 ns |  0.95 |    0.02 |         - |          NA |
| Lookup_Cascade   | .NET 9.0  | .NET 9.0  | 100000 | False | 1,566.9 ns | 26.17 ns | 24.48 ns |  1.57 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 100000 | False | 1,083.7 ns | 14.98 ns | 13.28 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 100000 | False |   965.3 ns | 18.82 ns | 24.47 ns |  0.89 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 100000 | False | 1,581.4 ns | 30.18 ns | 30.99 ns |  1.46 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| **Lookup_Equatable** | **.NET 10.0** | **.NET 10.0** | **100000** | **True**  | **3,023.3 ns** | **40.13 ns** | **37.53 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 100000 | True  | 3,530.0 ns | 69.85 ns | 85.79 ns |  1.17 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 100000 | True  | 3,878.7 ns | 76.83 ns | 75.46 ns |  1.28 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Cascade   | .NET 10.0 | .NET 10.0 | 100000 | True  | 1,485.3 ns | 28.12 ns | 36.56 ns |  1.00 |    0.03 |         - |          NA |
| Lookup_Cascade   | .NET 8.0  | .NET 8.0  | 100000 | True  | 1,483.7 ns | 29.48 ns | 46.76 ns |  1.00 |    0.04 |         - |          NA |
| Lookup_Cascade   | .NET 9.0  | .NET 9.0  | 100000 | True  | 1,908.5 ns | 25.65 ns | 23.99 ns |  1.29 |    0.03 |         - |          NA |
|                  |           |           |        |       |            |          |          |       |         |           |             |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 100000 | True  | 1,454.5 ns | 25.82 ns | 25.36 ns |  1.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 100000 | True  | 1,525.1 ns | 21.73 ns | 20.33 ns |  1.05 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 100000 | True  | 1,936.6 ns | 37.47 ns | 31.29 ns |  1.33 |    0.03 |         - |          NA |
