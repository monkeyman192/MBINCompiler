@REM -- DON'T TOUCH -------------------------
@echo off
setlocal
set SCRIPT_PATH=%~dp0
set SCRIPT_PATH=%SCRIPT_PATH:~0,-1%
set SCRIPT_NAME=%~n0
REM ----------------------------------------

REM CONFIGURABLES

REM Change these if you have forked the project.
set GITHUB_USER=monkeyman192
set GITHUB_REPO=MBINCompiler

REM Probably don't want to change these.
set REL_BRANCH=master
set PRE_BRANCH=development

REM -- DON'T TOUCH -------------------------
set MSG=%~1
if "%MSG%" == "" goto HELP

if "%GITHUB_TOKEN%" == "" goto INVALID_TOKEN

set REPO=%GITHUB_USER%/%GITHUB_REPO%

REM back out of .\BuildTools
set PROJECT_PATH=%SCRIPT_PATH%\..
set BUILD_PATH=%PROJECT_PATH%\Build\Release

set EXE_ARTIFACT=%BUILD_PATH%\MBINCompiler.exe
set DLL_ARTIFACT=%BUILD_PATH%\libMBIN.dll

set OPT_PRERELEASE=-prerelease
set BRANCH=%PRE_BRANCH%

for /f "tokens=1,2,3,4,5,6" %%I in ('call "_lib\libMBIN-VERSION.BAT"') do (
    set TAG=%%I
    set VERSION=%%J
    set MAJOR=%%K
    set MINOR=%%L
    set RELEASE=%%M
    set PRERELEASE=%%N
)

if %PRERELEASE% == 0 (
    REM if %RELEASE% == 0 goto INVALID_VERSION
    set OPT_PRERELEASE=
    set BRANCH=%REL_BRANCH%
)

echo TAG=%TAG%
echo VERSION=%VERSION%

REM Check that the build artifacts exist
if not exist "%EXE_ARTIFACT%" goto NOT_COMPILED
if not exist "%DLL_ARTIFACT%" goto NOT_COMPILED

REM Get the version reported from the compiled exe.
for /f %%I in ('"%BUILD_PATH%\MBINCompiler.exe" version -q') do set BUILD_VERSION=%%I

REM Debug
REM echo BUILD_VERSION=%BUILD_VERSION%

REM There's no guarantee the exe uses the latest source without building on demand
REM but at least make sure the version in the compiled exe matches the source code.
if not "%BUILD_VERSION%" == "%VERSION%" goto VERSION_MISMATCH

set STAGING_PATH=%SCRIPT_PATH%\DEPLOY.STAGING

REM delete the staging folder, in case it exists
rd /s /q "%STAGING_PATH%" > nul 2>&1
REM copy artifacts to staging folder
md "%STAGING_PATH%"
copy "%EXE_ARTIFACT%" "%STAGING_PATH%\" > nul 2>&1
copy "%DLL_ARTIFACT%" "%STAGING_PATH%\" > nul 2>&1

_bin\github-release %OPT_PRERELEASE% "%REPO%" "v%TAG%" "%BRANCH%" "%MSG%" "%STAGING_PATH%\*"

REM CLEANUP: delete the staging folder and it's contents
rd /s /q "%STAGING_PATH%" > nul 2>&1

exit /b 0


:HELP
    echo.%~nx0 ^<RELEASE MESSAGE^>
    echo.
    echo.Deploys a new release to the github repository (run from command line prompt).
    echo.
    echo.MAKE SURE libMBIN.Version.VERSION_STRING IS UPDATED!
    echo.
    echo.MAKE SURE ALL CHANGES ARE COMMITTED AND PUSHED TO THE PROJECT REPOSITORY BEFORE DEPLOYING!
    echo.
    echo.MAKE SURE THE PROJECT CAN BUILD SUCCESSFULLY BEFORE DEPLOYING!
    echo.
    echo.Parses VERSION_STRING from libMBIN.Version and converts it to a github tag.
    echo.If the Prerelease version number is not 0, then the tag format is "vX.X.X-preX", otherwise just "vX.X.X"
    echo.
    echo.If the tag already exists in the repository, the release is configured for that commit.
    echo.If not, then the latest commit on the release (%REL_BRANCH%) or prerelease (%PRE_BRANCH%) branch will be tagged, depending on the tag format.
    echo.
    pause
    exit /b 1

:INVALID_TOKEN
    echo.GITHUB_TOKEN environment variable not configured!
    echo.Deploying to github requires an access token.
    echo.
    echo.NOTE that you must be a project collaborator to be able to deploy to %GITHUB_USER%/%GITHUB_REPO%!
    echo.If you want to deploy to your own project, change the GITHUB_USER and GITHUB_REPO variables in this %~nx0 file then follow the below instructions.
    echo.
    echo.You must configure a GITHUB_TOKEN environment variable and set the value to your personal access token.
    echo.In the Windows Start menu search for 'environment' and select 'Edit environment variables for your account'.
    echo.Add the variable to the USER Environment variables, not System. Your token is private. The System variables are not!
    echo.(Close this console window and open a new one for your changes to work.)
    echo.
    echo.To create a github token, see here:
    echo.https://help.github.com/articles/creating-a-personal-access-token-for-the-command-line/
    echo.
    echo.The only token scopes required for this script are repo:status, repo_deployment and public_repo.
    echo.For security, it's advisable to have different tokens for different projects/tasks and keep the scope restricted as much as possible.
    echo.
    echo.DO NOT SHARE YOUR TOKEN.
    echo.DO NOT COMMIT!
    echo.
    pause
    exit /b 2

:INVALID_VERSION
    echo.
    echo.VERSION_STRING = "%VERSION%" is not valid!
    echo.
    echo.If Release is 0 then Prerelease must not be 0.
    echo.Change libMBIN.Version.VERSION_STRING to "%MAJOR%.%MINOR%.0.1"
    echo.
    pause
    exit /b 3

:VERSION_MISMATCH
    echo.
    echo.libMBIN.Version.VERSION_STRING does not match the compiled version in the Build\Release folder!
    echo."%VERSION%" != "%BUILD_VERSION%"
    goto NOT_COMPILED

:NOT_COMPILED
    echo.
    echo.You must compile a release build for the current version before deploying.
    echo.
    pause
    exit /b 4