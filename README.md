# MBINCompiler
**Project Owner**: monkeyman192

## DOWNLOAD ![Github Total Downloads](https://img.shields.io/github/downloads-pre/monkeyman192/MBINCompiler/total.svg) ![GitHub Latest Pre-Release Version](https://img.shields.io/github/release/monkeyman192/MBINCompiler/all.svg) ![GitHub Latest Release Version](https://img.shields.io/github/release/monkeyman192/MBINCompiler.svg)

_**For Modders:** You only need to download MBINCompiler.exe_  
_**For Developers:** You can download a precompiled DLL or get the libMBIN source and integrate with your own NMS modding tools._

[DOWNLOAD LATEST RELEASE](../../releases)  


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

If you are new to modding in NMS, check out the [NMS Modding Wiki](https://nmsmodding.wikia.com/wiki/No_Man%27s_Sky_Modding_Wiki) for how to get started before you continue with MBINCompiler.  

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

## SUBMITTING BUG REPORTS

If you run into errors, in most cases the errors are because:

a) You made an error when editing the EXML file and it fails to recompile.
Check if it's a problem with your file or with MBINCompiler by decompiling the vanilla MBIN to EXML and then recompling it back to MBIN to verify that it works or not. If the vanilla file recompiles fine, then it's most likely a problem with your file changes.

b) You are trying to use an older version of MBINCompiler with a newer version of MBIN/EXML or vice versa.  
Make sure you are using the correct version of MBINCompiler for the file you are trying to process.

c) MBINCompiler has yes to be updated for the current game version of the data structure used by a particular file.  
Check if there are any [Open Issues](../../issues) for the file you are having problems with.

If the vanilla MBIN fails to recompile, you are using the correct version of MBINCompiler and there are no issues already open that are related to the file, then open a [New issue](../../issues/new).

Detail as much information about the error and how to reproduce it as you can in your bug report.

Include:
- relevant error messages
- name and path of the file relative to the GAMEDATA folder
- the MBINCompiler version you are using
- the NMS version of the MBIN file


## CREDITS
Original project thanks to Emoose: https://github.com/emoose/MBINCompiler
