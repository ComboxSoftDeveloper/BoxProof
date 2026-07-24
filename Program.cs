using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using BoxProof.Benchmarks;

ManualConfig config = ManualConfig.Create(DefaultConfig.Instance)
    .AddExporter(MarkdownExporter.GitHub)
    .AddExporter(HtmlExporter.Default)
    .AddExporter(CsvExporter.Default);

BenchmarkRunner.Run<BoxBench>(config);

// dotnet run -c Release -f net10.0
