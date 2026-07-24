@echo off
cd /d %~dp0

dotnet build -c Release

rem Узкий фильтр: FindValue словаря + наши обёртки. Метод печатается
rem несколько раз (Tier0 -> Tier1) - смотреть ПОСЛЕДНИЙ листинг.
set DOTNET_JitDisasm=*FindValue* Lookup*

bin\Release\net8.0\Disasm.exe  > disasm_net8.txt   2>&1
bin\Release\net9.0\Disasm.exe  > disasm_net9.txt   2>&1
bin\Release\net10.0\Disasm.exe > disasm_net10.txt  2>&1
if exist bin\Release\net11.0\Disasm.exe (bin\Release\net11.0\Disasm.exe > disasm_net11.txt 2>&1)

set DOTNET_JitDisasm=

echo Gotovo: disasm_net8..11.txt
pause
