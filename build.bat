@echo off

set CSCDIR=%WINDIR%\Microsoft.NET\
set CSCVER=v4.0.30319

if "%PROCESSOR_ARCHITECTURE%" == "x86" (
    set CSCDIR=%CSCDIR%Framework\
) else (
    set CSCDIR=%CSCDIR%Framework64\
)

set CSCDIR=%CSCDIR%%CSCVER%\

%CSCDIR%csc.exe /out:Program.exe *.cs
