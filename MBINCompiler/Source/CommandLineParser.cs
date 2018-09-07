using System;
using System.Collections.Generic;

namespace MBINCompiler
{

    public class CommandLineParser {

        public struct Option {
            public char shortName;
            public string longName;

            public string param;

            public bool isRequired;
            public bool allowMultiple;

            public string description;

            public override string ToString() {
                string optShort = ( shortName != 0 ) ? $"-{shortName}" : "";
                string optLong = !String.IsNullOrWhiteSpace( longName ) ? $"--{longName}" : "";
                if ( !String.IsNullOrWhiteSpace( param ) ) {
                    optShort += ( optShort != "" ) ? param : "";
                    optLong += ( optLong != "" ) ? $"={param}" : "";
                }
                optShort += ( optShort != "" ) ? ", " : "";
                string option = String.Format( "{0}{1,-20}", optShort, optLong );
                const int OPTION_FIELD_WIDTH = 24;

                string desc = ( isRequired ? "(REQUIRED) " : "" ) + description;

                desc = CommandLine.WrapLine( desc, 4 + OPTION_FIELD_WIDTH );
                return String.Format( "  {0,-26}{1}", option, desc.TrimStart( ' ' ) );
            }
        }

        public class OptionArg {
            public string name;
            public string value;
        }

        private Dictionary<string, List<Option>> optionMap;

        public List<string> Args { get; private set; }

        public string Verb { get; private set; }

        private List<string>    optionKeys;
        private List<OptionArg> optionArgs;

        private List<string> fileParams;

        public CommandLineParser( string[] args ) {
            optionMap = new Dictionary<string, List<Option>>();
            this.Args  = new List<string>( args );
            optionKeys = new List<string>();
            optionArgs = new List<OptionArg>();
            fileParams = new List<string>();
        }

        public bool Parse( string defaultVerb ) {
            string[] keys = new string[optionMap.Count];
            optionMap.Keys.CopyTo( keys, 0 );
            ParseVerb( keys, defaultVerb );

            var options = optionMap[" COMMON "];
            options.AddRange( optionMap[Verb] );
            return ParseOptions( options );
        }

        public string ParseVerb( string[] verbs, string defaultVerb = "" ) {
            Verb = defaultVerb;
            if ( ( verbs == null ) || ( Args.Count == 0 ) ) { return Verb; }

            var arg = Args[0].ToLower();
            for ( int i = 0; i < verbs.Length; i++ ) {
                if ( arg == verbs[i] ) {
                    Verb = verbs[i];
                    Args.RemoveAt( 0 );
                    break;
                }
            }

            return Verb;
        }

        public bool ParseOptions( List<Option> options ) {
            var aliases = new Dictionary<string, string>();
            foreach ( var opt in options ) {
                if ( ( opt.shortName != 0 ) && !String.IsNullOrWhiteSpace( opt.longName ) ) {
                    aliases[$"{opt.shortName}"] = opt.longName;
                }
            }

            while (Args.Count > 0) {
                if (!ParseOption( options, aliases )) return false;
            }
            return true;
        }

        private bool ParseOption( List<Option> options, Dictionary<string, string> aliases ) {
            var arg = Args[0];
            if ( ( arg.Length > 1 ) && ( arg[0] == '-' ) ) {
                char switchChar = arg[1];
                arg = arg.Substring( 2 );

                string name = "";
                string key = "";
                string val = "";

                // if its a switch, then reformat it into a long option
                if ( switchChar != '-' ) {
                    name = $"{switchChar}";
                    key = switchChar.ToString();
                    if ( aliases.ContainsKey( key ) ) key = aliases[key];
                    arg = $"{key}={arg}";
                }

                var tokens = arg.Split( '=' );
                key = ( tokens.Length > 0 ) ? tokens[0] : "";
                val = ( tokens.Length > 1 ) ? tokens[1] : "";

                // find the key in the available options
                int index = -1;
                for (int i = 0; i < options.Count; i++) {
                    if ( ( ( key.Length == 1 ) && ( key[0] == options[i].shortName ) ) || ( key == options[i].longName ) ) {
                        index = i;
                        break;
                    }
                }
                if ( index < 0 ) return false;

                // if the option requires a param but we don't have one yet then get the next arg
                if ((options[index].param != null) && (val == "")) {
                    Args.RemoveAt( 0 );
                    val = Args[0];
                }
                    
                // unless multiples are allowed, remove the option from the list
                if (!options[index].allowMultiple) options.RemoveAt( index );

                AddOptionArg( key, name, val );
            } else {
                fileParams.Add( arg );
            }

            Args.RemoveAt( 0 );
            return true;
        }

        public void AddOption( string verb, Option option ) {
            verb = verb ?? " COMMON ";
            if (!optionMap.ContainsKey( verb )) optionMap[verb] = new List<Option>();
            optionMap[verb].Add( option );
        }

        public void AddOptions( string verb, List<Option> options ) {
            verb = verb ?? " COMMON ";
            if (!optionMap.ContainsKey( verb )) optionMap[verb] = new List<Option>();
            optionMap[verb].AddRange( options );
        }

        private void AddOptionArg( string key, OptionArg option ) {
            optionKeys.Add( key );
            optionArgs.Add( option );
        }

        private void AddOptionArg( string key, string switchName, string value ) {
            var option = new OptionArg { name = $"-{(switchName ?? $"-{key}")}", value = value };
            AddOptionArg( key, option );
        }

        private void RemoveOptionArg( int index ) {
            optionKeys.RemoveAt( index );
            optionArgs.RemoveAt( index );
        }

        public OptionArg GetOptionArg( string key ) {
            var index = optionKeys.IndexOf( key );
            if (index < 0) { return null; }
            var val = optionArgs[index];
            RemoveOptionArg( index );
            return val;
        }

        public bool GetOptionSwitch( string key ) => ( GetOptionArg( key ) != null );

        public List<string> GetFileParams() => fileParams;

    }

}
