# Порядок прогона

1. `dotnet run -c Release -f net10.0` - BDN, .NET 8/9/10, baseline - int-ключ на десятке.
   Если Setup упал со «сверка Setup не сошлась» - не мерять, прислать текст.
2. `Disasm\snap.bat` - дизасм FindValue и обёрток, все рантаймы.

Прислать: BenchmarkDotNet.Artifacts/results целиком + disasm_net*.txt + dotnet --list-sdks.
