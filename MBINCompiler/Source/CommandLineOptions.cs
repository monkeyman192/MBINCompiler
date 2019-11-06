using System;
using System.Collections.Generic;

namespace MBINCompiler
{
    using System.Text;
    using static CommandLineOptions.OptionBackers;
    using static CommandLineParser;
    using static Utils;

    using HeaderFormat = libMBIN.MBINHeader.Format;

    internal static class CommandLineOptions
    {

        public static class OptionBackers
        {
            public static bool optDebugMode              = false;
            public static bool optQuiet                  = false;
            public static OverwriteMode optOverwrite     = OverwriteMode.Prompt;
            public static bool optIgnoreErrors           = false;
            public static FormatType optInputFormat      = FormatType.Unknown;
            public static FormatType optOutputFormat     = FormatType.Unknown;
            public static List<string> optIncludeFilters = null;
            public static List<string> optExcludeFilters = null;
            public static HeaderFormat optFormatVersion  = HeaderFormat.V2;
            public static bool optUseThreads             = true;
        }

        // --debug
        public static bool DebugMode {
            get => optDebugMode;
            internal set {
                #if DEBUG
                    optDebugMode = true;
                #else
                    optDebugMode = value;
                #endif
            }
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

        // --format-version
        public static HeaderFormat FormatVersion { get => optFormatVersion; internal set => optFormatVersion = value; }

        // --no-threads
        public static bool UseThreads { get => optUseThreads; internal set => optUseThreads = value; }

        public static readonly List<Option> OPTIONS_GENERAL = new List<Option> {
            new Option { shortName = 'q', longName = "quiet",
                            description = "Do not display any console messages.\n" +
                                        "(Except requested help or version info.)\n" +
                                        "Do not wait for key press." },

            new Option { longName = "debug", isHidden = true,
                            description = "Unhide the help info for hidden debug options." }
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

            new Option { shortName = 'V', longName = "format-version", param = "[0|1|2]", isHidden = true,
                            description = "\nOutput using the specified MBIN format version.\n" +
                                          "Default is version 2." },

            new Option { longName = "no-threads", isHidden = true, description = "Disable multi-threading." },
        };

        public static readonly List<Option> OPTIONS_REGISTER = new List<Option> {
        };

        public static readonly List<Option> OPTIONS_UNREGISTER = new List<Option> {
        };

        public static readonly List<Option> OPTIONS_LIST = new List<Option> {
        };


        private static string FormatWrapped( string prefix, int padleft, string txt, bool trim = false ) {
            txt = CommandLine.WrapLine( txt, padleft );
            txt = trim ? txt.TrimStart( ' ' ) : txt;
            return String.Format( "{0,-" + $"{padleft}" + "}{1}", prefix, txt );
        }

        /// <summary>
        /// Display the help info.
        /// </summary>
        public static string GetHelpInfo() {
            string exe = GetExecutableName();

            var sb = new StringBuilder();
            
            sb.AppendLine( Version.GetVersionStringVerbose() );

            sb.Append( "\nUsage:\n\n"
                 + $"    {exe} help [<Option>...]\n"
                 + $"    {exe} version [<Option>...] [<File>]\n"
                 + $"    {exe} [convert] [<Option>...] <Path> [<Path>...]\n"
                 + $"    {exe} register [<Option>...] [<IconDirectory>]\n"
                 + $"    {exe} unregister [<Option>...] \n"
            );

            sb.Append( "\n\nModes:\n\n"
                  + FormatWrapped( "  help",       20, "Show this help info.", true )
                  + FormatWrapped( "  version",    20, "Show version info.", true )
                  + FormatWrapped( "  convert",    20, "Convert files between MBIN and EXML formats.", true )
                  + FormatWrapped( "  register",   20, "Register Windows system settings for MBINCompiler.", true)
                  + FormatWrapped( "  unregister", 20, "Unregister Windows system settings changed by MBINCompiler.", true)
            );

            if ( OPTIONS_GENERAL.Count > 0 ) {
                sb.Append( "\n\nGeneral Options:\n" );
                foreach ( var option in OPTIONS_GENERAL ) AppendOption( sb, option );
            }

            sb.Append( FormatWrapped( "\nversion [<Option>...] [<File>]\n\n", 4,
                    "    If no valid <File> is specified, the version for this exe is displayed.\n" +
                    "    If <File> is an MBIN, the version that the MBIN was compiled with will be displayed.\n" +
                    "\n" +
                    "    If -q or --quiet is used, a compact version string will be displayed with no decoration." ) );

            if ( OPTIONS_VERSION.Count > 0 ) {
                sb.Append( "\nversion Options:\n" );
                foreach ( var option in OPTIONS_VERSION ) AppendOption( sb, option );
            }

            sb.Append( FormatWrapped( "\n\n[convert] [<Option>...] <Path> [<Path>...]\n\n", 4,
                    "    This mode is the default. The convert keyword is optional.\n" +
                    "    For each <Path>, convert all files between MBIN and EXML formats." ) );

            if ( OPTIONS_CONVERT.Count > 0 ) {
                sb.Append( "\nconvert Options:\n" );
                foreach ( var option in OPTIONS_CONVERT ) AppendOption( sb, option );
            }

            sb.Append( FormatWrapped( "\n\nregister [<Option>...] [<IconDirectory>]\n\n", 4,
                    "    Register MBINCompiler with the windows system.\n" +
                    "\n" +
                    "      · adds MBINCompiler to the system PATH.\n" +
                    "      · adds custom icons for MBIN and EXML files.\n" +
                    "      · adds an explorer context menu item 'Convert to EXML' for MBIN files.\n" +
                    "      · adds an explorer context menu item 'Convert to MBIN' for EXML files.\n" +
                    "\n" +
                    "    MBINCompiler will search for MBIN.ICO and EXML.ICO files in the <IconDirectory> if it is\n" +
                    "    specified. If <IconDirectory> is not specified or either of ICO files are not found,\n" +
                    "    then MBINCompiler will search for an ./Icons folder in the directory containing the exe." ) );

            if (OPTIONS_REGISTER.Count > 0) {
                sb.Append( "\nregister Options:\n" );
                foreach ( var option in OPTIONS_REGISTER ) AppendOption( sb, option );
            }

            sb.Append( FormatWrapped( "\n\nunregister\n\n", 4,
                    "    Unregister MBINCompiler from the windows system.\n" +
                    "\n" +
                    "      · removes MBINCompiler from the system PATH.\n" +
                    "      · removes custom icons for MBIN and EXML files.\n" +
                    "      · removes explorer context menu item 'Convert to EXML' for MBIN files.\n" +
                    "      · removes explorer context menu item 'Convert to MBIN' for EXML files." ) );

            if (OPTIONS_UNREGISTER.Count > 0) {
                sb.Append( "\nunregister Options:\n" );
                foreach ( var option in OPTIONS_UNREGISTER ) AppendOption( sb, option );
            }

            if ( DebugMode ) {
                sb.Append( FormatWrapped( "\n\nlist [<Option>...]\n\n", 4,
                        "    List metadata for all supported MBIN structs." ) );

                if (OPTIONS_LIST.Count > 0) {
                    sb.Append( "\nlist Options:\n" );
                    foreach ( var option in OPTIONS_LIST ) AppendOption( sb, option );
                }
            }

            return sb.ToString();
        }

        private static void AppendOption( StringBuilder sb, Option option ) {
            if ( option.isHidden && !DebugMode ) return;
            sb.Append( option );
            sb.AppendLine();
        }

    }

}
