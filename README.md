# MBINCompiler
**Project Owner**: monkeyman192

## DOWNLOAD ![Github Total Downloads](https://img.shields.io/github/downloads-pre/monkeyman192/MBINCompiler/total.svg) ![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/monkeyman192/MBINCompiler?include_prereleases&label=release%20%28experimental%29) ![GitHub release (latest by date)](https://img.shields.io/github/v/release/monkeyman192/MBINCompiler?label=release%20%28public%29) [![MBIN test file coverage](https://img.shields.io/badge/dynamic/json?color=blueviolet&label=test%20file%20coverage&query=result&url=https%3A%2F%2Fgithub.com%2Fmonkeyman192%2FMBINCompiler%2Freleases%2Flatest%2Fdownload%2Freport.json)](https://github.com/monkeyman192/MBINCompiler/releases/latest/download/report.json) [![MBINCompiler](https://github.com/monkeyman192/MBINCompiler/actions/workflows/pipeline.yml/badge.svg?branch=development)](https://github.com/monkeyman192/MBINCompiler/actions/workflows/pipeline.yml)

_**For Modders:** You only need to download MBINCompiler.exe_  
_**For Developers:** You can download a precompiled DLL or get the libMBIN source and integrate with your own NMS modding tools._

[DOWNLOAD LATEST RELEASE](../../releases)  

** PLEASE NOTE:** MBINCompiler requires .NET 5 to run. If you do not have this you can download is [here](https://dotnet.microsoft.com/download/dotnet/5.0/runtime)
Some applications which depend on libMBIN however require a .NET 4 version of the library, and this is also provided with the downloads in each release.

Each release contains the following files:

- libMBIN.dll: A library which can be used by other applications to directly interface with the serilialised data contained within .MBIN files.
- MBINCompiler.exe: The main application used to convert .MBIN file to .EXML files and back again. Drag a file or folder of files onto the exe and away you go!
- mapping.json: A .json file which contains a mapping to de-obfuscate the save file .json used by the game.
- report.json: A report generated which indicated which of the test files passed or failed the automated tests. This is just for reporting purposes.

## DESCRIPTION
A modding tool for the game: [No Man's Sky](https://www.nomanssky.com/) that converts the game's MBIN data files (binary) into human-readable EXML files (text) that can be edited with any text editor and then converted back again for use in a modded game.

Various MBIN files have different data formats. MBINCompiler maps all of these formats to be able to understand how to read the binary data from file, convert it to EXML and vice versa.

**Please note** that every update to the game breaks any number of MBIN formats. This requires updating MBINCompiler for each game update and depending on the size and frequency of updates, can take some time so please be patient as new game updates roll out.

Because each version of MBINCompiler is tied to a specific version of NMS, it is also **very important to note** that MBIN files
compiled with a previous version may not be decompiled successfully with a newer version of MBINCompiler if that particular MBIN format has changed. The correct version of MBINCompiler should be used to decompile the corresponding file, then it can be updated and recompiled with the newer version.

If you need to find out what version of MBINCompiler to download for a particular MBIN file, there is a `--version` command line option that will tell you what version the MBIN file was compiled with. You can get more information about the command line options in the [User Documentation](https://github.com/monkeyman192/MBINCompiler/wiki/User-Documentation).

If you are a developer, you can access all the functionality that MBINCompiler uses for it's own command line interface by downloading or compiling the libMBIN.dll and linking it in your own application. The API makes things like MBIN/EXML de/serialization acessible as well as all the MBIN structure definitions. The structures are C# classes that map the mbin data as public fields, so they can be used in code like any other class.

If you need help, would like to help or just interested in NMS modding, check out the [No Man's Sky Modding Server](https://discordapp.com/invite/3Ytkxss) on discord chat.


## USAGE INSTRUCTIONS

If you are new to modding in NMS, check out the [NMS Modding Wiki](https://stepmodifications.org/wiki/NoMansSky:Landing_Page) for how to get started before you continue with MBINCompiler.  

The version of MBINCompiler you should download will depend on what version of the game you are using. When the experimental version is different to the public version (as can happen shortly after release), make sure to download the appropriate version based on the badges above.

Before you decompile any MBIN files you must know how to unpack the game assets.  
To use your recompiled MBIN files, you must know how to enable mods, install them and how to repack assets into your own mods.

To create a modified MBIN:  
1) Drag the MBIN file onto the MBINCompiler.exe to create an EXML file in the same directory as the MBIN file.  
_The exe does not need to be in the same directory._
2) Open the EXML file with a text, xml or code editor. Make your changes and save.  
_[Notepad++](https://notepad-plus-plus.org/) is good._
3) Drag the EXML file onto the MBINCompiler.exe to recompile back to an MBIN file.

Repack your file(s) into a new mod and add to your game.

See the [User-Documentation](../../wiki/User-Documentation) on the wiki for more details and advanced usage.

MBINCompiler/libMBIN are required for [AMUMSS](https://www.nexusmods.com/nomanssky/mods/957) which is a tool which uses the [lua programming language](https://www.lua.org/) to make mods which are much more resiliant to game updates than previous methods.

### COMMAND LINE ARGUMENTS

MBINCompiler has a number of arguments that can be called from the command line which may be useful:

`MBINCompiler.exe version [<Option> ...] [<File>]` - prints the version of the MBINCompiler binary (if no arguments provided), or the version of MBINCompiler that was used to generate the .MBIN or .EXML file if the filepath to one is provided.

`MBINCompiler.exe register` - Registers the directory that the MBINCompiler.exe resides in to your system path. This allows you to call `MBINCompiler` from anywhere on your computer which is useful.

`MBINCompiler.exe <path> [<path> ...]` - Converts the input path(s) from their input format (either .MBIN or .EXML) to the output format (.MBIN -> .EXML, .EXML -> .MBIN). This is the default mode.

There are also a number of other options that can be passed to the executable in most modes. To see all the details call `MBINCompiler.exe help` to see the help details.

## SUBMITTING BUG REPORTS

If you run into errors, in most cases the errors are because:

a) You made an error when editing the EXML file and it fails to recompile.
Check if it's a problem with your file or with MBINCompiler by decompiling the vanilla MBIN to EXML and then recompling it back to MBIN to verify that it works or not. If the vanilla file recompiles fine, then it's most likely a problem with your file changes.

b) You are trying to use an older version of MBINCompiler with a newer version of MBIN/EXML or vice versa.  
Make sure you are using the correct version of MBINCompiler for the file you are trying to process.

c) MBINCompiler has yet to be updated for the current game version of the data structure used by a particular file.  
Check if there are any [Open Issues](../../issues) for the file you are having problems with.

If the vanilla MBIN fails to recompile, you are using the correct version of MBINCompiler and there are no issues already open that are related to the file, then open a [New issue](../../issues/new).

Detail as much information about the error and how to reproduce it as you can in your bug report.

Include:
- relevant error messages
- name and path of the file relative to the GAMEDATA folder
- the MBINCompiler version you are using
- the NMS version of the MBIN file

## Building MBINCompiler/libMBIN

While this library targets multiple frameworks, building MBINCompiler and libMBIN locally will need to be done via the use of the `dotnet publish` command and the framework needs to be specified by the `-f` argument.

The full command to build all the libraries under the .NET  framework looks like:

```sh
dotnet publish -c Release -f net5.0-windows -r win-x64 -o Build/Release/net5/ /nowarn:cs0618
```

For convenience we have included two batch scripts which build either the entire project for the .NET 5 framework (`build.bat`), or just libMBIN for the .NET 4 framework (`build-dotnet4.bat`).


## TESTING INSTRUCTIONS

For anyone helping to develop MBINCompiler, if you are contributing new structs or updating existing ones, it is good to ensure that the tests that are run on the CI service that builds and tests MBINCompiler will pass.

### Requirements

To run the tests you will need python installed and on the path. It is recommended you get a recent version (3.7 or above).
The required dependencies are `pytest` and `requests`. These can be installed by entering `python -m pip install -U pytest requests` in your favorite command line program.
Before running the tests, you need to have built a `Release` version of MBINCompiler locally.

### Running the tests

Open a command line window in the root MBINCompiler directory and enter `python -m pytest`.
This will pull the latest test data into the directory `./tests/data`.

#### Command line arguments:

- `--datapath`: "The relative or absolute path to a folder containing .MBIN files to be tested. If not provided, the test data will be downloaded from the MBINCompiler-test-data repository."
- `--use_cache` (bool): "Whether or not to use cached data that was downloaded by running the tests with no additional arguments."
  Defaults to `False`.
- `--rerun`: "If tests are failing, you can chose to just re-run the ones that have failed."

  **Choices**:

    `all` (Default) - Run all tests again, ignoring any `_failed.txt` file in the directory.

    `failed` - Run only the failed tests again. Names are retrieved from a `_failed.txt` file in the same directory.

- `--report` (bool): "Whether to output a report of the failure to the local directory."
  Defaults to `False`.

**Notes:**
Use of `--use_cache=True` should only be done if you are 100% sure that the local data is up to date with the external test data as the tests run on the CI will pull the external test data every time.

`--datapath` is primarily used for running tests on folder of data files to test which files pass or fail for the updating of the `MBINCompiler-test-data` repository. This option can however be used to point the tests at any other directory (such as an unpacked PCBANKS directory or sub-folder to run the tests on any of the games' files.)

## CREDITS
Original project thanks to Emoose: https://github.com/emoose/MBINCompiler
