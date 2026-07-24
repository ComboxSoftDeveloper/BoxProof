```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method           | Job       | Runtime   | Size   | Hit   | Mean        | Error     | StdDev    | Median      | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |---------- |---------- |------- |------ |------------:|----------:|----------:|------------:|------:|--------:|----------:|------------:|
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **16**     | **False** |    **579.3 ns** |   **1.89 ns** |   **1.67 ns** |    **579.0 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 16     | False |  4,877.9 ns |  85.56 ns |  87.87 ns |  4,888.1 ns |  8.42 |    0.15 |    8192 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 16     | False |  1,528.7 ns |  11.13 ns |  10.41 ns |  1,524.1 ns |  2.64 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 16     | False |  1,388.8 ns |   7.52 ns |   6.66 ns |  1,388.1 ns |  2.40 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 16     | False |    870.0 ns |   4.03 ns |   3.77 ns |    869.5 ns |  1.50 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 16     | False |    519.4 ns |   3.61 ns |   3.38 ns |    521.0 ns |  0.90 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 16     | False |    842.1 ns |   8.16 ns |   7.63 ns |    845.2 ns |  1.45 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 16     | False |  1,320.5 ns |   7.44 ns |   6.60 ns |  1,323.8 ns |  2.28 |    0.01 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 16     | False |    789.5 ns |   4.82 ns |   4.51 ns |    791.6 ns |  1.36 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 16     | False |  5,447.4 ns |  28.18 ns |  26.36 ns |  5,441.9 ns |  9.40 |    0.05 |    8192 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 16     | False |  1,637.1 ns |   7.71 ns |   7.22 ns |  1,635.9 ns |  2.83 |    0.01 |         - |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 16     | False |  1,280.3 ns |   8.27 ns |   7.73 ns |  1,276.2 ns |  2.21 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 16     | False |    834.0 ns |   5.15 ns |   4.81 ns |    833.9 ns |  1.44 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 16     | False |    567.8 ns |  11.21 ns |  11.01 ns |    562.1 ns |  0.98 |    0.02 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 16     | False |    709.2 ns |   2.83 ns |   2.21 ns |    709.7 ns |  1.22 |    0.01 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 16     | False |  1,900.1 ns |   5.93 ns |   4.63 ns |  1,899.3 ns |  3.28 |    0.01 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 16     | False |    852.1 ns |  12.83 ns |  12.00 ns |    853.6 ns |  1.47 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 16     | False |  5,344.5 ns |  51.69 ns |  48.36 ns |  5,357.2 ns |  9.23 |    0.08 |    8192 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 16     | False |  1,333.1 ns |   8.18 ns |   7.25 ns |  1,332.1 ns |  2.30 |    0.01 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 16     | False |  1,257.3 ns |   5.88 ns |   5.22 ns |  1,257.4 ns |  2.17 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 16     | False |    725.5 ns |   5.94 ns |   5.56 ns |    726.4 ns |  1.25 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 16     | False |    622.5 ns |   7.21 ns |   6.74 ns |    624.3 ns |  1.07 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 16     | False |    707.6 ns |   6.27 ns |   5.87 ns |    709.7 ns |  1.22 |    0.01 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 16     | False |  1,909.7 ns |   6.96 ns |   6.51 ns |  1,910.4 ns |  3.30 |    0.01 |         - |          NA |
|                  |           |           |        |       |             |           |           |             |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **16**     | **True**  |    **535.5 ns** |   **2.92 ns** |   **2.73 ns** |    **536.1 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 16     | True  |  7,705.0 ns | 199.00 ns | 570.96 ns |  7,422.2 ns | 14.39 |    1.06 |   24576 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 16     | True  |  2,546.2 ns |  27.28 ns |  25.51 ns |  2,539.4 ns |  4.75 |    0.05 |    8192 B |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 16     | True  |  1,596.4 ns |   4.39 ns |   4.11 ns |  1,595.6 ns |  2.98 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 16     | True  |    947.1 ns |   2.42 ns |   2.26 ns |    946.6 ns |  1.77 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 16     | True  |    535.0 ns |   1.86 ns |   1.74 ns |    534.8 ns |  1.00 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 16     | True  |  1,057.1 ns |   7.22 ns |   6.75 ns |  1,058.9 ns |  1.97 |    0.02 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 16     | True  |  1,899.3 ns |  12.55 ns |  11.74 ns |  1,895.8 ns |  3.55 |    0.03 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 16     | True  |    893.1 ns |   4.76 ns |   4.45 ns |    891.0 ns |  1.67 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 16     | True  |  9,226.1 ns | 157.60 ns | 131.60 ns |  9,299.3 ns | 17.23 |    0.25 |   24576 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 16     | True  |  2,583.3 ns |  33.26 ns |  27.77 ns |  2,572.0 ns |  4.82 |    0.06 |    8192 B |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 16     | True  |  1,744.5 ns |   6.31 ns |   5.60 ns |  1,744.0 ns |  3.26 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 16     | True  |  1,088.0 ns |   3.87 ns |   3.43 ns |  1,088.4 ns |  2.03 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 16     | True  |    492.2 ns |   2.18 ns |   2.04 ns |    491.9 ns |  0.92 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 16     | True  |    919.5 ns |   3.75 ns |   3.51 ns |    920.0 ns |  1.72 |    0.01 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 16     | True  |  3,513.3 ns |  23.54 ns |  22.02 ns |  3,516.3 ns |  6.56 |    0.05 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 16     | True  |    785.7 ns |   5.65 ns |   5.28 ns |    787.7 ns |  1.47 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 16     | True  |  8,428.8 ns |  45.28 ns |  37.81 ns |  8,418.8 ns | 15.74 |    0.10 |   24576 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 16     | True  |  2,539.3 ns |  47.37 ns |  44.31 ns |  2,529.3 ns |  4.74 |    0.08 |    8192 B |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 16     | True  |  1,462.9 ns |  11.43 ns |  10.69 ns |  1,461.5 ns |  2.73 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 16     | True  |    791.8 ns |   6.67 ns |   6.24 ns |    789.2 ns |  1.48 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 16     | True  |    502.9 ns |   4.86 ns |   4.54 ns |    500.7 ns |  0.94 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 16     | True  |    872.7 ns |   7.80 ns |   7.29 ns |    869.3 ns |  1.63 |    0.02 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 16     | True  |  2,677.4 ns |   6.99 ns |   5.46 ns |  2,677.2 ns |  5.00 |    0.03 |         - |          NA |
|                  |           |           |        |       |             |           |           |             |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **1000**   | **False** |    **507.1 ns** |   **1.23 ns** |   **1.09 ns** |    **506.9 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 1000   | False |  5,854.0 ns |  87.30 ns |  81.66 ns |  5,848.8 ns | 11.54 |    0.16 |    8192 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 1000   | False |  1,418.1 ns |   9.12 ns |   8.08 ns |  1,416.6 ns |  2.80 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 1000   | False |  1,263.3 ns |   7.64 ns |   6.38 ns |  1,264.4 ns |  2.49 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 1000   | False |    939.5 ns |  10.18 ns |   9.52 ns |    936.1 ns |  1.85 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 1000   | False |    500.9 ns |   7.15 ns |   6.69 ns |    503.5 ns |  0.99 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 1000   | False |    798.9 ns |   3.65 ns |   3.24 ns |    799.0 ns |  1.58 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 1000   | False |  1,480.1 ns |  19.06 ns |  17.83 ns |  1,474.5 ns |  2.92 |    0.03 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 1000   | False |    877.7 ns |   3.99 ns |   3.34 ns |    876.2 ns |  1.73 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 1000   | False |  5,665.7 ns |  21.25 ns |  18.84 ns |  5,662.5 ns | 11.17 |    0.04 |    8192 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 1000   | False |  1,431.9 ns |  11.28 ns |  10.55 ns |  1,427.9 ns |  2.82 |    0.02 |         - |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 1000   | False |  1,389.8 ns |  10.21 ns |   9.05 ns |  1,385.4 ns |  2.74 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 1000   | False |  1,036.2 ns |  15.57 ns |  14.56 ns |  1,034.1 ns |  2.04 |    0.03 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 1000   | False |    522.9 ns |  10.20 ns |  10.01 ns |    521.2 ns |  1.03 |    0.02 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 1000   | False |    744.8 ns |  13.14 ns |  12.29 ns |    738.1 ns |  1.47 |    0.02 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 1000   | False |  2,939.4 ns |  51.96 ns |  48.60 ns |  2,914.6 ns |  5.80 |    0.09 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 1000   | False |    791.6 ns |  13.87 ns |  12.97 ns |    784.6 ns |  1.56 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 1000   | False |  7,459.8 ns | 144.77 ns | 193.26 ns |  7,462.8 ns | 14.71 |    0.38 |    8192 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 1000   | False |  1,331.6 ns |  19.54 ns |  18.28 ns |  1,331.1 ns |  2.63 |    0.04 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 1000   | False |  1,286.8 ns |  20.03 ns |  18.74 ns |  1,287.5 ns |  2.54 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 1000   | False |    916.3 ns |   1.08 ns |   1.01 ns |    916.2 ns |  1.81 |    0.00 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 1000   | False |    512.3 ns |   0.74 ns |   0.62 ns |    512.3 ns |  1.01 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 1000   | False |    757.1 ns |   0.93 ns |   0.82 ns |    757.2 ns |  1.49 |    0.00 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 1000   | False |  2,250.6 ns |  10.31 ns |   9.14 ns |  2,247.5 ns |  4.44 |    0.02 |         - |          NA |
|                  |           |           |        |       |             |           |           |             |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **1000**   | **True**  |    **539.2 ns** |   **1.87 ns** |   **1.66 ns** |    **538.8 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 1000   | True  |  9,155.1 ns | 181.36 ns | 222.73 ns |  9,137.1 ns | 16.98 |    0.41 |   24576 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 1000   | True  |  3,155.5 ns |  41.46 ns |  34.62 ns |  3,160.3 ns |  5.85 |    0.06 |    8192 B |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 1000   | True  |  1,681.1 ns |   4.72 ns |   3.94 ns |  1,681.8 ns |  3.12 |    0.01 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 1000   | True  |  1,126.0 ns |   3.22 ns |   2.86 ns |  1,126.8 ns |  2.09 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 1000   | True  |    543.6 ns |   0.71 ns |   0.59 ns |    543.7 ns |  1.01 |    0.00 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 1000   | True  |  1,152.0 ns |   6.67 ns |   5.91 ns |  1,153.4 ns |  2.14 |    0.01 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 1000   | True  |  2,325.5 ns |  10.29 ns |   8.60 ns |  2,325.7 ns |  4.31 |    0.02 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 1000   | True  |    910.0 ns |   3.61 ns |   3.37 ns |    910.5 ns |  1.69 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 1000   | True  | 10,879.5 ns | 196.38 ns | 183.69 ns | 10,951.8 ns | 20.18 |    0.34 |   24576 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 1000   | True  |  3,157.8 ns |  60.74 ns | 147.84 ns |  3,118.5 ns |  5.86 |    0.27 |    8192 B |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 1000   | True  |  1,970.6 ns |  35.34 ns |  34.71 ns |  1,965.3 ns |  3.65 |    0.06 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 1000   | True  |  1,158.1 ns |   6.08 ns |   5.69 ns |  1,156.8 ns |  2.15 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 1000   | True  |    499.4 ns |   2.89 ns |   2.56 ns |    499.0 ns |  0.93 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 1000   | True  |  1,077.8 ns |  10.40 ns |   8.68 ns |  1,077.8 ns |  2.00 |    0.02 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 1000   | True  |  4,696.6 ns |  29.47 ns |  27.57 ns |  4,694.6 ns |  8.71 |    0.06 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 1000   | True  |    786.5 ns |   6.10 ns |   5.70 ns |    786.2 ns |  1.46 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 1000   | True  | 10,016.6 ns | 199.43 ns | 500.33 ns | 10,061.4 ns | 18.58 |    0.92 |   24576 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 1000   | True  |  3,543.6 ns |  68.16 ns |  86.20 ns |  3,578.0 ns |  6.57 |    0.16 |    8192 B |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 1000   | True  |  1,617.1 ns |   7.84 ns |   7.34 ns |  1,617.8 ns |  3.00 |    0.02 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 1000   | True  |  1,030.4 ns |  16.75 ns |  15.67 ns |  1,030.3 ns |  1.91 |    0.03 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 1000   | True  |    494.7 ns |   4.47 ns |   4.18 ns |    494.9 ns |  0.92 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 1000   | True  |  1,007.5 ns |   5.56 ns |   5.20 ns |  1,007.8 ns |  1.87 |    0.01 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 1000   | True  |  3,847.0 ns |  30.62 ns |  28.64 ns |  3,849.8 ns |  7.14 |    0.06 |         - |          NA |
|                  |           |           |        |       |             |           |           |             |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **100000** | **False** |    **505.5 ns** |   **4.01 ns** |   **3.75 ns** |    **506.3 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 100000 | False |  7,812.5 ns | 130.76 ns | 122.31 ns |  7,880.2 ns | 15.45 |    0.26 |    8192 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 100000 | False |  1,909.4 ns |  10.22 ns |   9.56 ns |  1,911.0 ns |  3.78 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 100000 | False |  1,794.8 ns |   9.79 ns |   9.15 ns |  1,792.9 ns |  3.55 |    0.03 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 100000 | False |    939.9 ns |   3.72 ns |   3.48 ns |    939.3 ns |  1.86 |    0.01 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 100000 | False |    507.0 ns |   4.60 ns |   4.30 ns |    509.0 ns |  1.00 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 100000 | False |  1,162.2 ns |  13.28 ns |  12.42 ns |  1,159.9 ns |  2.30 |    0.03 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 100000 | False |  2,107.0 ns |  20.74 ns |  18.39 ns |  2,105.3 ns |  4.17 |    0.05 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 100000 | False |    890.0 ns |   4.16 ns |   3.69 ns |    889.6 ns |  1.76 |    0.01 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 100000 | False |  5,639.6 ns | 107.21 ns | 123.46 ns |  5,637.6 ns | 11.16 |    0.25 |    8192 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 100000 | False |  2,078.3 ns |   7.43 ns |   6.58 ns |  2,078.7 ns |  4.11 |    0.03 |         - |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 100000 | False |  1,969.6 ns |  10.10 ns |   8.96 ns |  1,967.4 ns |  3.90 |    0.03 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 100000 | False |    895.3 ns |  12.58 ns |  11.15 ns |    899.8 ns |  1.77 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 100000 | False |    598.5 ns |   5.68 ns |   5.31 ns |    599.6 ns |  1.18 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 100000 | False |  1,116.5 ns |   6.88 ns |   6.10 ns |  1,116.1 ns |  2.21 |    0.02 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 100000 | False |  3,812.8 ns |  43.76 ns |  34.17 ns |  3,810.6 ns |  7.54 |    0.08 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 100000 | False |    793.8 ns |   8.95 ns |   8.38 ns |    794.5 ns |  1.57 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 100000 | False |  8,998.2 ns | 142.80 ns | 133.57 ns |  8,975.3 ns | 17.80 |    0.29 |    8192 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 100000 | False |  2,474.8 ns |  37.86 ns |  33.56 ns |  2,467.0 ns |  4.90 |    0.07 |         - |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 100000 | False |  2,341.3 ns |  13.79 ns |  11.51 ns |  2,341.9 ns |  4.63 |    0.04 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 100000 | False |  1,263.9 ns |   5.01 ns |   4.45 ns |  1,264.9 ns |  2.50 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 100000 | False |    794.5 ns |   7.75 ns |   7.24 ns |    794.8 ns |  1.57 |    0.02 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 100000 | False |  1,581.5 ns |  20.13 ns |  18.83 ns |  1,580.5 ns |  3.13 |    0.04 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 100000 | False |  3,072.8 ns |  51.30 ns |  47.98 ns |  3,082.0 ns |  6.08 |    0.10 |         - |          NA |
|                  |           |           |        |       |             |           |           |             |       |         |           |             |
| **Lookup_Int**       | **.NET 10.0** | **.NET 10.0** | **100000** | **True**  |    **536.2 ns** |   **4.78 ns** |   **4.47 ns** |    **535.5 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Lookup_Plain     | .NET 10.0 | .NET 10.0 | 100000 | True  | 10,337.3 ns | 204.83 ns | 336.54 ns | 10,434.9 ns | 19.28 |    0.64 |   24576 B |          NA |
| Lookup_Override  | .NET 10.0 | .NET 10.0 | 100000 | True  |  3,904.7 ns |  76.65 ns |  96.94 ns |  3,916.8 ns |  7.28 |    0.19 |    8192 B |          NA |
| Lookup_Equatable | .NET 10.0 | .NET 10.0 | 100000 | True  |  2,491.2 ns |  16.73 ns |  14.83 ns |  2,491.4 ns |  4.65 |    0.05 |         - |          NA |
| Lookup_Record    | .NET 10.0 | .NET 10.0 | 100000 | True  |  1,149.7 ns |   9.43 ns |   8.36 ns |  1,150.7 ns |  2.14 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 10.0 | .NET 10.0 | 100000 | True  |    531.8 ns |   3.26 ns |   3.05 ns |    532.1 ns |  0.99 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 10.0 | .NET 10.0 | 100000 | True  |  1,630.6 ns |  13.23 ns |  12.38 ns |  1,627.4 ns |  3.04 |    0.03 |         - |          NA |
| Lookup_String    | .NET 10.0 | .NET 10.0 | 100000 | True  |  3,204.7 ns |  32.01 ns |  29.94 ns |  3,208.5 ns |  5.98 |    0.07 |         - |          NA |
| Lookup_Int       | .NET 8.0  | .NET 8.0  | 100000 | True  |    891.8 ns |   6.43 ns |   6.01 ns |    892.8 ns |  1.66 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 8.0  | .NET 8.0  | 100000 | True  |  9,712.8 ns | 194.16 ns | 307.96 ns |  9,833.9 ns | 18.11 |    0.58 |   24576 B |          NA |
| Lookup_Override  | .NET 8.0  | .NET 8.0  | 100000 | True  |  4,150.7 ns |  80.90 ns |  93.16 ns |  4,151.6 ns |  7.74 |    0.18 |    8192 B |          NA |
| Lookup_Equatable | .NET 8.0  | .NET 8.0  | 100000 | True  |  2,812.6 ns |  17.93 ns |  15.89 ns |  2,818.2 ns |  5.25 |    0.05 |         - |          NA |
| Lookup_Record    | .NET 8.0  | .NET 8.0  | 100000 | True  |  1,225.6 ns |   8.10 ns |   7.58 ns |  1,226.0 ns |  2.29 |    0.02 |         - |          NA |
| Lookup_Enum      | .NET 8.0  | .NET 8.0  | 100000 | True  |    489.9 ns |   3.83 ns |   3.58 ns |    491.6 ns |  0.91 |    0.01 |         - |          NA |
| Lookup_Guid      | .NET 8.0  | .NET 8.0  | 100000 | True  |  1,546.7 ns |  12.93 ns |  12.09 ns |  1,543.9 ns |  2.88 |    0.03 |         - |          NA |
| Lookup_String    | .NET 8.0  | .NET 8.0  | 100000 | True  |  5,977.3 ns |  57.28 ns |  53.58 ns |  5,965.5 ns | 11.15 |    0.13 |         - |          NA |
| Lookup_Int       | .NET 9.0  | .NET 9.0  | 100000 | True  |    777.5 ns |   5.82 ns |   5.45 ns |    778.2 ns |  1.45 |    0.02 |         - |          NA |
| Lookup_Plain     | .NET 9.0  | .NET 9.0  | 100000 | True  | 12,021.9 ns | 140.38 ns | 131.31 ns | 12,012.6 ns | 22.42 |    0.30 |   24576 B |          NA |
| Lookup_Override  | .NET 9.0  | .NET 9.0  | 100000 | True  |  4,238.8 ns |  53.58 ns |  50.12 ns |  4,247.1 ns |  7.90 |    0.11 |    8192 B |          NA |
| Lookup_Equatable | .NET 9.0  | .NET 9.0  | 100000 | True  |  2,870.4 ns |  39.89 ns |  37.31 ns |  2,869.5 ns |  5.35 |    0.08 |         - |          NA |
| Lookup_Record    | .NET 9.0  | .NET 9.0  | 100000 | True  |  1,528.9 ns |   8.56 ns |   7.59 ns |  1,531.1 ns |  2.85 |    0.03 |         - |          NA |
| Lookup_Enum      | .NET 9.0  | .NET 9.0  | 100000 | True  |    791.6 ns |   8.60 ns |   8.04 ns |    795.0 ns |  1.48 |    0.02 |         - |          NA |
| Lookup_Guid      | .NET 9.0  | .NET 9.0  | 100000 | True  |  2,049.3 ns |  17.11 ns |  15.17 ns |  2,041.8 ns |  3.82 |    0.04 |         - |          NA |
| Lookup_String    | .NET 9.0  | .NET 9.0  | 100000 | True  |  5,016.1 ns |  20.76 ns |  19.42 ns |  5,014.6 ns |  9.35 |    0.08 |         - |          NA |
