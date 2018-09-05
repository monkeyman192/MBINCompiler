@REM -- DON'T TOUCH -------------------------
@echo off
setlocal
set SCRIPT_PATH=%~dp0
set SCRIPT_PATH=%SCRIPT_PATH:~0,-1%
set SCRIPT_NAME=%~n0
REM ----------------------------------------

REM Back out of BuildTools\_lib
set PROJECT_PATH=%SCRIPT_PATH%\..\..

REM Relative to PROJECT_PATH
set VERSION_PATH=libMBIN\Source\Version.cs

for /f "usebackq tokens=4,6 delims=; " %%I in ( "%PROJECT_PATH%\%VERSION_PATH%" ) do if "%%I" == "VERSION_STRING" set VERSION=%%~J
for /f "tokens=1,2,3,4 delims=." %%A in ("%VERSION%") do (
    set VERSION_STRING=%%A.%%B.%%C
    set MAJOR=%%A
    set MINOR=%%B
    set RELEASE=%%C
    set PRERELEASE=%%D
)

if %PRERELEASE% GTR 0 set SUFFIX=-pre%PRERELEASE%

echo %VERSION_STRING%%SUFFIX% %VERSION% %MAJOR% %MINOR% %RELEASE% %PRERELEASE%
