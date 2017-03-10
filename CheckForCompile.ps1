param([bool]$mbin=$false, [bool]$verbose=$true, [bool]$excludeModels=$true)
# This script will recursively step through all the files and folders checking for MBIN files.
# when it finds and MBIN file it will check to see if that file has it's sibling EXML file.
# If the EXML is not found the MBIN can automatically be run through MBIN Compiler (per param)
# and will be added to output.txt (which is cleared on each run).
#
# Please make sure to fill in the path to MBIN Compiler (or a link to MBIN Compiler below)

$MBINCompilerLocation = 'S:\Game Mods\No Mans Sky\Tools\_Toolbox\MBINCompiler.exe.lnk'


If (test-path("output.txt")){
	If (test-path("output_old.txt")){
		remove-item output_old.txt
	}
	Rename-Item output.txt output_old.txt
}

Write "Checking Files..."

write-host -NoNewline "Run files through MBINCompiler? " $mbin `n
write-host -NoNewline "Verbose Output? " $verbose `n
write-host -NoNewline "Skip MODELS Directory? " $excludeModels `n
pause

Get-ChildItem $PSScriptRoot -recurse -Filter *.mbin |

Foreach-Object {
    #Skip if in MODELS directory and skip Models is enabled
    If ($excludeModels -eq $true -AND $_.FullName -Like "*MODELS*"){
        return
    } 
    If ($verbose -eq $true){
        write-host -NoNewline "Checking : " $_.BaseName `n
    }
    $FullMBIN = $_.FullName
    If ($verbose -eq $true){
        write-host -nonewline "MBIN File : " $FullMBIN `n
    }
    $FullEXML = $FullMBIN.Replace(".MBIN",".exml")
    If ($verbose -eq $true){
        write-host -nonewline "EXML File : " $FullEXML `n
    }
    If (Test-Path($FullEXML)){
        If ($verbose -eq $true){
            write-host -NoNewline "EXML Found!"
        }
    }
    Else{
        If ($verbose -eq $true){
            write-host -NoNewline "EXML Missing!"
        }
        If ($mbin -eq $true){
            if ($verbose -eq $true){
                write-host -NoNewline "Attempting MBIN Compiler..."
            }
            & $MBINCompilerLocation $FullMBIN
        }
        $PastePath = $FULLMBIN.Replace("D:\Games\SteamLibrary\steamapps\common\No Man's Sky\GAMEDATA","- [ ] ")
		$PastePath = $PastePath.Replace("\","/")
        Add-Content output.txt $PastePath
    }
}