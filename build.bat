dotnet publish -c Release -f net5.0-windows -r win-x64 -o Build/Release/net5/ /nowarn:cs0618
dotnet publish libMBIN-DLL -c Release -f net452 -r win-x64 -o Build/Release/net4/ /nowarn:cs0618
pause