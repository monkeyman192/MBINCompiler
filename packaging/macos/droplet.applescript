-- MBINCompiler droplet — drag .MBIN/.MXML files onto the app icon to convert them.
-- MBIN → MXML and MXML → MBIN are auto-detected; output is written next to each
-- source file.
--
-- It uses, in order: an `MBINCompiler` sitting next to this droplet (the unzipped
-- archive layout), then the `mbincompiler` command on your PATH (run install.sh).
-- Looking beside the droplet first means you don't have to install anything, and a
-- bundled copy always wins over an older MBINCompiler already on your PATH.
--
-- Compiled to an .app with:  osacompile -o "MBINCompiler Droplet.app" droplet.applescript

-- Resolve the MBINCompiler executable. GUI-launched apps don't inherit your shell
-- PATH, so we look beside the droplet first, then the locations install.sh uses.
on findTool()
	set appPath to POSIX path of (path to me)
	set sh to "appdir=$(dirname " & quoted form of appPath & ")
for cand in \"$appdir/MBINCompiler\" \"$(pwd)/MBINCompiler\"; do
  [ -x \"$cand\" ] && { echo \"$cand\"; exit 0; }
done
for d in \"$HOME/.local/bin\" /opt/homebrew/bin /usr/local/bin; do
  [ -x \"$d/mbincompiler\" ] && { echo \"$d/mbincompiler\"; exit 0; }
done
command -v mbincompiler 2>/dev/null"
	try
		set toolPath to do shell script sh
		if toolPath is "" then error "not found"
		return toolPath
	on error
		display dialog "MBINCompiler wasn't found." & return & return & "Keep this droplet in the same folder as the MBINCompiler executable, or run install.sh to add it to your PATH, then try again." buttons {"OK"} default button "OK" with icon stop with title "MBINCompiler"
		error number -128 -- quietly abort
	end try
end findTool

on run
	-- Double-clicked instead of dropped onto.
	display dialog "Drag .MBIN or .MXML files onto this app icon to convert them." & return & return & "MBIN → MXML and MXML → MBIN are detected automatically, and the result is written next to each source file." buttons {"OK"} default button "OK" with title "MBINCompiler"
end run

on open theFiles
	set tool to findTool()
	set okCount to 0
	set failures to {}
	repeat with f in theFiles
		set p to POSIX path of f
		try
			do shell script quoted form of tool & " -y -f " & quoted form of p
			set okCount to okCount + 1
		on error errMsg
			set end of failures to p & " — " & errMsg
		end try
	end repeat
	if (count of failures) = 0 then
		display notification ((okCount as text) & " file(s) converted.") with title "MBINCompiler"
	else
		set msg to (okCount as text) & " converted, " & (count of failures as text) & " failed:" & return & return
		repeat with oneFailure in failures
			set msg to msg & oneFailure & return
		end repeat
		display dialog msg buttons {"OK"} default button "OK" with icon caution with title "MBINCompiler"
	end if
end open
