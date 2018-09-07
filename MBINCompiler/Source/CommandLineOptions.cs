using System;
using System.Collections.Generic;

namespace MBINCompiler
{
    using System.Text;
    using static CommandLineOptions.OptionBackers;
    using static CommandLineParser;
    using static Utils;

    internal static class CommandLineOptions
    {

        public static class OptionBackers
        {
            public static bool optQuiet;
            public static OverwriteMode optOverwrite;
            public static bool optIgnoreErrors;
            public static FormatType optInputFormat;
            public static FormatType optOutputFormat;
            public static List<string> optIncludeFilters;
            public static List<string> optExcludeFilters;
        }

        // --quiet
        public static bool Quiet { get => optQuiet; internal set => optQuiet = value; }

        // --overwrite and --keep
        public static OverwriteMode Overwrite { get => optOverwrite; internal set => optOverwrite = value; }

        // --force
        public static bool IgnoreErrors { get => optIgnoreErrors; internal set => optIgnoreErrors = value; }

        // --input-format
        public static FormatType InputFormat { get => optInputFormat; internal set => optInputFormat = value; }

        // --output-format
        public static FormatType OutputFormat { get => optOutputFormat; internal set => optOutputFormat = value; }

        // --include
        public static List<string> IncludeFilters { get => optIncludeFilters; internal set => optIncludeFilters = value; }

        // --exclude
        public static List<string> ExcludeFilters { get => optExcludeFilters; internal set => optExcludeFilters = value; }

        public static readonly List<Option> OPTIONS_GENERAL = new List<Option> {
            new Option { shortName = 'q', longName = "quiet",
                            description = "Do not display any console messages.\n" +
                                        "(Except requested help or version info.)\n" +
                                        "Do not wait for key press." },
        };

        public static readonly List<Option> OPTIONS_HELP = new List<Option> {
        };

        public static readonly List<Option> OPTIONS_VERSION = new List<Option> {
            //new Option { shortName = 'q', longName = "quiet",
            //             description = "Display a compact version string only,, with no decoration.\n" +
            //                           "For scripts and tools." }
        };

        public static readonly List<Option> OPTIONS_CONVERT = new List<Option> {
            //new Option { shortName = 'q', longName = "quiet",
            //             description = "Do not display any console messages.\n" +
            //                           "Do not wait for key press." },

            new Option { shortName = 'y', longName = "overwrite",
                            description = "Always overwrite files if they already exist." },

            new Option { shortName = 'n', longName = "keep",
                            description = "Never overwrite files if they already exist." },

            new Option { shortName = 'f', longName = "force",
                            description = "Skip files with errors and continue processing.\n" +
                                        "Do not pause for errors.\n" +
                                        "(Any errors will be written to MBINCompiler.log)" },

            new Option { shortName = 'd', longName = "output-dir", param = "<Directory>",
                            description = "\nSpecify the directory where files will be written to.\n" +
                                        "If this option is used, only one input <Path> can be specified." },

            new Option { shortName = 'i', longName = "input-format", param = "<Type>",
                            description = "\nSpecify the type of input files to be converted from.\n" +
                                        "<Type> can be either MBIN or EXML." },

            new Option { shortName = 'o', longName = "output-format", param = "<Type>",
                            description = "\nSpecify the type of output files to be converted to.\n" +
                                        "<Type> can be either MBIN or EXML." },

            new Option { longName = "include", param = "<Glob Pattern>[;<Glob Pattern>...]",
                            description = "\nFilter all files to include only those that match the " +
                                        "glob patterns. A glob pattern is a filepath with wildcards." +
                                        "The * and ? wildcard characters can be used.\n" +
                                        "Multiple glob patterns are separated by a semicolon.\n" +
                                        "The default is --include=\"*.MBIN;*.MBIN.PC;*.EXML\" (all).\n" +
                                        "The --include filter is applied before --exclude." },

            new Option { longName = "exclude", param = "<Glob Pattern>[;<Glob Pattern>...]",
                            description = "\nFilter all files to exclude any that match the " +
                                        "glob patterns. A glob pattern is a filepath with wildcards." +
                                        "The * and ? wildcard characters can be used.\n" +
                                        "Multiple glob patterns are separated by a semicolon.\n" +
                                        "The default is --exclude=\"LANGUAGE\\*;*.GEOMETRY.*\".\n" +
                                        "The --exclude filter is applied after --include." },
        };

        private static string FormatWrapped( string prefix, int padleft, string txt, bool trim = false )
        {
            txt = CommandLine.WrapLine( txt, padleft );
            txt = trim ? txt.TrimStart( ' ' ) : txt;
            return String.Format( "{0,-" + $"{padleft}" + "}{1}", prefix, txt );
        }

        /// <summary>
        /// Display the help info.
        /// </summary>
        public static string GetHelpInfo()
        {
            string exe = GetExecutableName();

            var sw = new StringBuilder();
            
            sw.AppendLine( Version.GetVersionStringVerbose() );

            sw.Append( "\nUsage:\n\n" +
                   $"    {exe} help\n" +
                   $"    {exe} version [(-q | --quiet)] [<File>]\n" +
                   $"    {exe} [convert] [<Option>...] [<Path>...]\n" );

            sw.Append( "\n\nModes:\n\n" +
                    FormatWrapped( "  help", 20, "Show this help info.", true ) +
                    FormatWrapped( "  version", 20, "Show version info.", true ) +
                    FormatWrapped( "  convert", 20, "Convert files between MBIN and EXML formats.", true ) );

            if ( OPTIONS_GENERAL.Count > 0 ) {
                sw.Append( "\n\nGeneral Options:\n" );
                foreach ( var option in OPTIONS_GENERAL ) { sw.Append(option ); sw.AppendLine(); }
            }

            sw.Append( FormatWrapped( "\nversion [<Option>...] [<File>]\n\n", 4,
                    "    If no valid <File> is specified, the version for this exe is displayed.\n" +
                    "    If <File> is an MBIN, the version that the MBIN was compiled with will be displayed.\n" +
                    "\n" +
                    "    If -q or --quiet is used, a compact version string will be displayed with no decoration." ) );

            if ( OPTIONS_VERSION.Count > 0 ) {
                sw.Append( "\nversion Options:\n" );
                foreach ( var option in OPTIONS_VERSION ) { sw.Append(option ); sw.AppendLine(); }
            }

            sw.Append( FormatWrapped( "\n\n[convert] [<Option>...] [<Path>...]\n\n", 4,
                    "    This mode is the default. The convert keyword is optional.\n" +
                    "    For each <Path>, convert all files between MBIN and EXML formats." ) );

            if ( OPTIONS_CONVERT.Count > 0 ) {
                sw.Append( "\nconvert Options:\n" );
                foreach ( var option in OPTIONS_CONVERT ) { sw.Append(option ); sw.AppendLine(); }
            }

            return sw.ToString();
        }

    }

}
