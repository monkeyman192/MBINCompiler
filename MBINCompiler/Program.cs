using System;
using System.Collections.Generic;
using System.IO;

namespace MBINCompiler
{
    class Program
    {
        static void ScanMBINs(string path, ref List<string> types)
        {
            foreach (var file in Directory.GetFiles(path, "*.mbin*"))
            {
                var mbin = new MBINFile(file);
                mbin.Load();
                types.Add($"{file} : {mbin.Header.GetXMLTemplateName()}");
            }
            foreach (var folder in Directory.GetDirectories(path))
                ScanMBINs(folder, ref types);
        }

        static void DecompileFile(string input, string output, bool getVersion = false)
        {
            if (String.IsNullOrEmpty(output))
                output = input;

            output = Path.ChangeExtension(output, ".exml"); // emoose XML, because there's no way this XML format is compatible with MXML

            if (File.Exists(output))
                File.Delete(output); // todo: ask for confirmation?

            // no error checking ^^ (todo: error checking)
            var file = new MBINFile(input);
            file.Load(getVersion);

            if (!getVersion)
            {
                var data = file.GetData();
                if (data == null)
                {
                    Console.WriteLine($"Failed to deserialize template \"{file.Header.GetXMLTemplateName()}\", has the structure been mapped yet?");
                    return;
                }

                var xmlString = EXmlFile.WriteTemplate(data);
                if (string.IsNullOrEmpty(xmlString))
                {
                    Console.WriteLine($"Error serializing template \"{file.Header.GetXMLTemplateName()}\" to XML!");
                    return;
                }
                File.WriteAllText(output, xmlString);
                Console.WriteLine($"XML data written to \"{output}\" successfully?");
            }
        }

        static void CompileFile(string input, string output)
        {
            if (String.IsNullOrEmpty(output))
                output = input;

            output = Path.ChangeExtension(output, ".MBIN");

            var data = EXmlFile.ReadTemplate(input);
            if (data == null)
            {
                Console.WriteLine("Failed to deserialize EXML file, is it formatted correctly?");
                return;
            }

            if (data.GetType() == typeof(Models.Structs.TkGeometryData))
                output = Path.ChangeExtension(output, ".MBIN.PC");

            if (File.Exists(output))
                File.Delete(output); // todo: ask for confirmation?

            using (var file = new MBINFile(output))
            {
                file.Header = new Models.MBINHeader();
                file.Header.SetDefaults();
                if (data.GetType() == typeof(Models.Structs.TkGeometryData))
                    file.Header.Magic = 0xDDDDDDDD; // only used by TkGeometryData / .MBIN.PC files, maybe used to signal the file is PC only?

                file.SetData(data);
                file.Save();
            }

            Console.WriteLine($"MBIN data written to \"{output}\" successfully?");
        }

        static void decompileFolder(string inPath, string outPath)
        {
            if (string.IsNullOrEmpty(outPath)) outPath = inPath;

            foreach (var file in Directory.GetFiles(inPath, "*.mbin*"))
            {
                if (file.Contains("LANGUAGE") || file.Contains("language"))
                    continue;

                if (!file.EndsWith(".mbin", StringComparison.InvariantCultureIgnoreCase)
                    && !file.EndsWith(".mbin.pc", StringComparison.InvariantCultureIgnoreCase))
                    continue;

                var output = file.Replace(inPath, outPath);
                if (!Directory.Exists(Path.GetDirectoryName(output)))
                    Directory.CreateDirectory(Path.GetDirectoryName(output));

                try
                {
                    DecompileFile(file, output);
                }
                catch { }
            }

            foreach (var dir in Directory.GetDirectories(inPath))
            {
                string outDirPath = dir.Replace(inPath, outPath);
                decompileFolder(dir, outDirPath);
            }
        }

        static void compileFolder(string folderPath, string outPath)
        {
            if (string.IsNullOrEmpty(outPath))
            {
                Console.WriteLine("Output folder not specified. Bulk compile aborted.");
                return;
            }

            foreach (var file in Directory.GetFiles(folderPath, "*.exml"))
            {
                if (file.Contains("LANGUAGE") || file.Contains("language"))
                    continue;

                if (!file.EndsWith(".exml", StringComparison.InvariantCultureIgnoreCase) && !file.EndsWith(".exml.pc", StringComparison.InvariantCultureIgnoreCase))
                    continue;

                var output = file.Replace(folderPath, outPath);
                if (!Directory.Exists(Path.GetDirectoryName(output)))
                    Directory.CreateDirectory(Path.GetDirectoryName(output));

                try
                {
                    CompileFile(file, output);
                }
                catch { }
            }

            foreach (var dir in Directory.GetDirectories(folderPath))
            {
                string outDirPath = dir.Replace(folderPath, outPath);
                compileFolder(dir, outDirPath);
            }
        }

        static void PrintHelp()
        {
            Console.WriteLine(@"Usage: MBINCompiler [Input File or Folder]");
            Console.WriteLine(@"Will write decompiled output to [Input File].exml or [Input Folder]\*.exml");

            Console.WriteLine(@"Usage: MBINCompiler [Input Folder] [Output Folder]");
            Console.WriteLine(@"Will write decompiled & recompile files from [Input Folder] and write them to [Output Folder]");

            Console.WriteLine("Recompiling .exml back to .mbin is available for testing, use at your own risk!");
        }

        static void Main(string[] args)
        {
            string input, output;
            bool getVer = false;

            if (args.Length < 1 || args[0] == "/?" || args[0] == "/help" || args[0] == "--help" || args[0] == "-h")
            {
                PrintHelp();
                return;
            }

            foreach (string arg in args)
            {
                if (arg == "-version" || arg == "-v")
                {
                    if (args[0] == "-version" || args[0] == "-v")
                    {
                        string ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                        Console.WriteLine(ver.Substring(0, ver.Length - 2));
                        return;
                    }
                    if (args[1] == "-version" || args[1] == "-v")
                        getVer = true;
                }
            }

            try
            { 
                input = Path.GetFullPath(args[0]);
                output = args.Length > 1 ? Path.GetFullPath(args[1]) : String.Empty;
            }
            catch(Exception ex)
            {
                PrintHelp();
                return;
            }

            string inputExtension = Path.GetExtension(input) ?? String.Empty;
            if (inputExtension.Equals(".mbin", StringComparison.OrdinalIgnoreCase) || input.EndsWith(".mbin.pc", StringComparison.OrdinalIgnoreCase))
                DecompileFile(input, output, getVer);
            else if (inputExtension.Equals(".exml", StringComparison.OrdinalIgnoreCase)) 
                CompileFile(input, output);
            else if (String.IsNullOrEmpty(inputExtension) && Directory.Exists(input))
            {
                decompileFolder(input, output);
                compileFolder(input, output);
            }
            else
            {
                bool isMBin = false;
                if(File.Exists(input) && new FileInfo(input).Length > 0x60)
                {
                    using (var stream = File.OpenRead(input))
                    using (var reader = new BinaryReader(stream))
                    {
                        var magic = reader.ReadUInt32();
                        var unk4 = reader.ReadUInt32();
                        isMBin = (magic == 0xCCCCCCCC || magic == 0xDDDDDDDD) && unk4 == 2500; // CC CC CC CC C4 09 00 00
                    }
                }

                if (isMBin)
                    DecompileFile(input, output, getVer);
                else
                    Console.WriteLine($"Unsupported file extension {inputExtension}!");
            }
                
        }
    }
}