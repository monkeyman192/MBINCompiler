using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace libMBIN
{

    /// <summary>
    /// Handles logging messages to a log stream.
    /// </summary>
    internal static class Logger {

        private static StreamWriter _logStream = null;
        private static TextWriterTraceListener _traceListener = null;

        /// <summary>
        /// The stream that log messages are output to.
        /// Use <see cref="Open(StreamWriter, bool, bool)"/> to set the stream.
        /// </summary>
        /// <seealso cref="Open(StreamWriter, bool, bool)"/><seealso cref="Close"/>
        public static StreamWriter LogStream {
            get => _logStream;
            private set {
                TraceListener = null;
                if ( DisposeWhenClosed ) _logStream?.Dispose();
                _logStream = value;
            }
        }
        /// <summary>
        /// If true, then any existing LogStream will be disposed when <see cref="Open(StreamWriter, bool, bool)"/>
        /// or <see cref="Close"/> is called.
        /// </summary>
        /// <seealso cref="Open(StreamWriter, bool, bool)"/><seealso cref="Close"/>
        public static bool DisposeWhenClosed { get; set; } = true;

        /// <summary>
        /// The TraceListener for LogStream that listens for Debug and Trace messages.
        /// If the Logger is closed, this will be null.
        /// Otherwise this will be a valid <see cref="TextWriterTraceListener"/> object, regardless if
        /// either <see cref="EnableTraceLogging"/> or <see cref="EnableDebugLogging"/> is true.
        /// </summary>
        public static TextWriterTraceListener TraceListener {
            get => _traceListener;
            private set {
                RemoveListener();
                _traceListener?.Dispose();
                _traceListener = value;
            }
        }

        /// <summary>
        /// If true, Debug messages will be logged to LogStream. Default is false.
        /// This is an alias for <see cref="EnableTraceLogging"/>.
        /// It is not possible to enable or disable Debug and Trace logging independently.
        /// </summary>
        public static bool EnableDebugLogging {
            get => (TraceListener != null);
            set => SetListener( value );
        }

        /// <summary>
        /// If true, Trace messages will be logged to LogStream. Default is false.
        /// This is an alias for <see cref="EnableDebugLogging"/>.
        /// It is not possible to enable or disable Debug and Trace logging independently.
        /// </summary>
        public static bool EnableTraceLogging {
            get => (TraceListener != null);
            set => SetListener( value );
        }

        private static void SetListener( bool enable ) {
            TraceListener = null;
            if ( !enable ) return;
            TraceListener = new TextWriterTraceListener( LogStream, "libMBIN.Logger" );
            Trace.Listeners.Add( TraceListener );
        }

        private static void RemoveListener() {
            if ( TraceListener == null ) return;
            Trace.Listeners.Remove( TraceListener );
        }

        private static TextWriterTraceListener consoleListener = null;
        public static bool LogToConsole {
            get => (consoleListener != null);
            set {
                if ( consoleListener != null ) Debug.Listeners.Remove( consoleListener );
                consoleListener = value ? (consoleListener ?? new ConsoleTraceListener()) : null;
                if ( value ) Debug.Listeners.Add( new ConsoleTraceListener() );
            }
        }

        #region // Indent
        private static int _indentSize = 2;
        private static int _indentLevel = 0;

        private static Stack<int> indentStack = new Stack<int>();

        /// <summary>
        /// The number of spaces for each level of indentation.
        /// This also sets <see cref="Debug.IndentSize"/> and <see cref="Trace.IndentSize"/>.
        /// </summary>
        /// <seealso cref="IndentLevel"/><seealso cref="IndentString(string)"/>
        /// <seealso cref="Indent"/><seealso cref="Unindent"/>
        /// <seealso cref="PushIndent(int)"/><seealso cref="PopIndent"/><seealso cref="IndentScope"/>
        public static int IndentSize {
            get => _indentSize;
            set {
                IndentPadding = new string( ' ', (_indentSize = value) * _indentLevel );
                Debug.IndentSize = Trace.IndentSize = value;
            }
        }

        /// <summary>
        /// The current level of indentation.
        /// This also sets <see cref="Debug.IndentLevel"/> and <see cref="Trace.IndentLevel"/>.
        /// </summary>
        /// <seealso cref="IndentSize"/><seealso cref="IndentString(string)"/>
        /// <seealso cref="Indent"/><seealso cref="Unindent"/>
        /// <seealso cref="PushIndent(int)"/><seealso cref="PopIndent"/><seealso cref="IndentScope"/>
        public static int IndentLevel {
            get => _indentLevel;
            set {
                IndentPadding = new string( ' ', _indentSize * (_indentLevel = value) );
                Debug.IndentLevel = Trace.IndentLevel = value;
            }
        }

        private static string IndentPadding { get; set; } = "";

        /// <summary>Apply an indent to <paramref name="txt"/> using the Logger indentation.</summary>
        /// <param name="txt">The string to indent.</param>
        /// <returns>The indented string.</returns>
        /// <seealso cref="IndentSize"/><seealso cref="IndentLevel"/>
        /// <seealso cref="Indent"/><seealso cref="Unindent"/>
        /// <seealso cref="PushIndent(int)"/><seealso cref="PopIndent"/><seealso cref="IndentScope"/>
        public static string IndentString( string txt ) => $"{IndentPadding}{txt}";

        /// <summary>Increment <see cref="IndentLevel"/></summary>
        /// <seealso cref="Unindent"/>
        /// <seealso cref="PushIndent(int)"/><seealso cref="PopIndent"/><seealso cref="IndentScope"/>
        /// <seealso cref="IndentSize"/><seealso cref="IndentLevel"/><seealso cref="IndentString(string)"/>
        public static void Indent() => IndentLevel++;

        /// <summary>Decrement <see cref="IndentLevel"/></summary>
        /// <seealso cref="Indent"/>
        /// <seealso cref="PushIndent(int)"/><seealso cref="PopIndent"/><seealso cref="IndentScope"/>
        /// <seealso cref="IndentSize"/><seealso cref="IndentLevel"/><seealso cref="IndentString(string)"/>
        public static void Unindent() => IndentLevel = Math.Max( 0, --IndentLevel );

        /// <summary>
        /// Save the current indent level and sets it to a new value.
        /// Use <see cref="PopIndent"/> to restore the previous state.
        /// </summary>
        /// <param name="level">
        /// The new indentation level.
        /// If not specified or less than 0, then the current intent level will be incremented by 1.
        /// Default is -1 (increment).
        /// </param>
        /// <returns>The current indent level, before being changed.</returns>
        /// <seealso cref="PopIndent"/>
        /// <seealso cref="Indent"/><seealso cref="Unindent"/><seealso cref="IndentScope"/>
        /// <seealso cref="IndentSize"/><seealso cref="IndentLevel"/><seealso cref="IndentString(string)"/>
        public static int PushIndent( int level = -1 ) {
            int current = IndentLevel;
            indentStack.Push( current );
            IndentLevel = (level < 0) ? IndentLevel + 1 : level;
            return current;
        }

        /// <summary>
        /// Restore the previous indent level that was saved with <see cref="PushIndent(int)"/>
        /// </summary>
        /// <returns>The current indent level, after being restored.</returns>
        /// <seealso cref="PushIndent(int)"/>
        /// <seealso cref="Indent"/><seealso cref="Unindent"/><seealso cref="IndentScope"/>
        /// <seealso cref="IndentSize"/><seealso cref="IndentLevel"/><seealso cref="IndentString(string)"/>
        public static int PopIndent() {
            IndentLevel = indentStack.Pop();
            return IndentLevel;
        }

        /// <summary>
        /// Create an instance with a using statement and any log messages within the using block will be indented.
        /// When the block closes, IndentScope is disposed and the previous indent level is restored.
        /// Similar to explicitly calling <see cref="PushIndent(int)"/> and <see cref="PopIndent"/> but is handled implicitly.
        /// </summary>
        /// <example><code>
        /// Logger.LogMessage("line 1");
        /// using (var indentScope = new Logger.IndentScope()) {
        ///     Logger.LogMessage("line 2");
        ///     Logger.LogMessage("line 3");
        /// }
        /// Logger.LogMessage("line 4");
        /// </code></example>
        /// <seealso cref="PushIndent(int)"/><seealso cref="PopIndent"/>
        /// <seealso cref="Indent"/><seealso cref="Unindent"/>
        /// <seealso cref="IndentSize"/><seealso cref="IndentLevel"/><seealso cref="IndentString(string)"/>
        public class IndentScope : IDisposable {
            private readonly int previous;

            /// <summary>
            /// Save the current indent level and sets it to a new value.
            /// When the IndentScope object is disposed/destroyed, the previous indent level will be restored.
            /// </summary>
            /// <param name="level">
            /// The new indentation level.
            /// If not specified or less than 0, then the current intent level will be incremented by 1.
            /// Default is -1 (increment).
            /// </param>
            public IndentScope( int level = -1 ) {
                previous = IndentLevel;
                IndentLevel = (level < 0) ? ++IndentLevel : level;
            }

            /// <summary>
            /// You shouldn't need to call this directly.
            /// The using statement will call this automatically when the block terminates.
            /// </summary>
            public void Dispose() => IndentLevel = previous;
        }
        #endregion

        /// <summary>
        /// Open a file for writing and attach the stream to Logger.
        /// If <paramref name="logfile"/> already exists, its contents will be overwritten.
        /// </summary>
        /// <param name="logfile">The file that Logger will write to.</param>
        /// <param name="autoflush"><see cref="Open(StreamWriter, bool, bool)"/></param>
        /// <param name="dispose"><see cref="Open(StreamWriter, bool, bool)"/></param>
        /// <returns>A new StreamWriter using the opened file stream.</returns>
        /// <seealso cref="Open(Stream, bool, bool)"/>
        /// <seealso cref="Open(StreamWriter, bool, bool)"/>
        /// <seealso cref="Close"/>
        public static StreamWriter Open( string logfile, bool autoflush = true, bool dispose = true ) {
            return Open( new FileStream( logfile, FileMode.Create ), autoflush, dispose );
        }

        /// <summary>Attach a Stream to Logger.</summary>
        /// <param name="stream">The Stream that Logger will write to.</param>
        /// <param name="autoflush"><see cref="Open(StreamWriter, bool, bool)"/></param>
        /// <param name="dispose"><see cref="Open(StreamWriter, bool, bool)"/></param>
        /// <returns>A new StreamWriter using stream.</returns>
        /// <seealso cref="Open(string, bool, bool)"/>
        /// <seealso cref="Open(StreamWriter, bool, bool)"/>
        /// <seealso cref="Close"/>
        public static StreamWriter Open( Stream stream, bool autoflush = true, bool dispose = true ) {
            return Open( new StreamWriter( stream ), autoflush, dispose );
        }

        /// <summary>Attach a StreamWriter to Logger.</summary>
        /// <param name="stream">The StreamWriter that Logger will write to.</param>
        /// <param name="autoflush">
        /// Default is true.
        /// If true, all data will be flushed automatically as it is writtern.
        /// If false, data will only be flushed when the buffer is filled.
        /// If autoflush is not used, any remaining data in the buffer after writing
        /// is finished must be manually flushed by calling <see cref="StreamWriter.Flush"/> on the logStream.
        /// </param>
        /// <param name="dispose">
        /// Default is true.
        /// If true, then the existing logStream will be disposed when <see cref="Open(StreamWriter, bool, bool)"/>
        /// or <see cref="Close"/> is called.
        /// If false, then <see cref="Stream.Dispose"/> must be manually called on logStream.
        /// </param>
        /// <returns>stream</returns>
        /// <seealso cref="Open(string, bool, bool)"/>
        /// <seealso cref="Open(Stream, bool, bool)"/>
        /// <seealso cref="Close"/>
        public static StreamWriter Open( StreamWriter stream, bool autoflush = true, bool dispose = true ) {
            IndentSize  = _indentSize;  // needed to sync with Debug and Trace loggers
            IndentLevel = _indentLevel; // needed to sync with Debug and Trace loggers

            Close();
            LogStream = stream;
            if ( LogStream == null ) return null;

            LogStream.AutoFlush = autoflush;
            DisposeWhenClosed = dispose;

            return LogStream;
        }

        /// <summary>
        /// Release any resources the Logger is using.
        /// If <see cref="DisposeWhenClosed"/> is true then call <see cref="Stream.Dispose"/> on <see cref="LogStream"/>.</summary>
        /// <seealso cref="Open(string, bool, bool)"/>
        /// <seealso cref="Open(Stream, bool, bool)"/>
        /// <seealso cref="Open(StreamWriter, bool, bool)"/>
        public static void Close() => LogStream = null;


        /// <summary>Output a log message to any Debug listeners. The message will be prepended with a DEBUG label.</summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "DEBUG" )] public static void LogDebug( object obj ) => LogDebug( null, "{0}", obj );
        /// <summary>Output a log message to any Debug listeners. The message will be prepended with a DEBUG label.</summary>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "DEBUG" )] public static void LogDebug( string tag, object obj ) => LogDebug( tag, "{0}", obj );
        /// <summary>Output a log message to any Debug listeners.</summary>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "DEBUG" )] public static void LogDebug( string label, string tag, object obj ) => LogDebug( label, tag, "{0}", obj );
        /// <summary>Output a log message to any Debug listeners. The message will be prepended with a DEBUG label.</summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "DEBUG" )] public static void LogDebug( string format, params object[] args ) => LogDebug( null, format, args );
        /// <summary>Output a log message to any Debug listeners. The message will be prepended with a DEBUG label.</summary>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "DEBUG" )] public static void LogDebug( string tag, string format, params object[] args ) => LogDebug( "DEBUG", tag, format, args );
        /// <summary>Output a log message to any Debug listeners.</summary>
        /// <param name="label">A label to prepend to the log message. If label is null and tag is not null then label will default to DEBUG.</param>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "DEBUG" )]
        public static void LogDebug( string label, string tag, string format, params object[] args ) {
            label = !string.IsNullOrWhiteSpace( label ) ? label : null;
            tag = !string.IsNullOrWhiteSpace( tag ) ? tag : null;
            tag = (tag != null) ? $":{tag}" : null; // if there's a tag then format it
            label = (tag != null) ? (label ?? "DEBUG") : label; // if there's a tag and no label then default label to "DEBUG"
            Debug.WriteLine( string.Format( format, args ), string.IsNullOrWhiteSpace( label ) ? null : $"[{label}]" );
        }

        /// <summary>Output a log message to any Trace listeners. The message will be prepended with a TRACE label.</summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        [Conditional( "TRACE" )] public static void LogTrace( object obj ) => LogTrace( null, "{0}", obj );
        /// <summary>Output a log message to any Trace listeners. The message will be prepended with a TRACE label.</summary>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        [Conditional( "TRACE" )] public static void LogTrace( string tag, object obj ) => LogTrace( tag, "{0}", obj );
        /// <summary>Output a log message to any Trace listeners.</summary>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        [Conditional( "TRACE" )] public static void LogTrace( string label, string tag, object obj ) => LogTrace( label, tag, "{0}", obj );
        /// <summary>Output a log message to any Trace listeners. The message will be prepended with a TRACE label.</summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        [Conditional( "TRACE" )] public static void LogTrace( string format, params object[] args ) => LogTrace( null, format, args );
        /// <summary>Output a log message to any Trace listeners. The message will be prepended with a TRACE label.</summary>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        [Conditional( "TRACE" )] public static void LogTrace( string tag, string format, params object[] args ) => LogTrace( "TRACE", tag, format, args );
        /// <summary>Output a log message to any Trace listeners.</summary>
        /// <param name="label">A label to prepend to the log message. If label is null and tag is not null then label will default to TRACE.</param>
        /// <param name="tag">A tag that will be combined with the label and prepended to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        [Conditional( "TRACE" )]
        public static void LogTrace( string label, string tag, string format, params object[] args ) {
            label = !string.IsNullOrWhiteSpace( label ) ? label : null;
            tag = !string.IsNullOrWhiteSpace( tag ) ? tag : null;
            tag = (tag != null) ? $":{tag}" : null; // if there's a tag then format it
            label = (tag != null) ? (label ?? "TRACE") : label; // if there's a tag and no label then default label to "TRACE"
            Trace.WriteLine( string.Format( format, args ), string.IsNullOrWhiteSpace( label ) ? null : $"[{label}]" );
        }

        /// <summary>Output a general message to the log and additionally to Console.Out.</summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        public static void LogOutput( object obj ) => LogMessage( Console.Out, null, "{0}", obj );
        /// <summary>Output a general message to the log and additionally to Console.Out.</summary>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        public static void LogOutput( string label, object obj ) => LogMessage( Console.Out, label, "{0}", obj );
        /// <summary>Output a general message to the log and additionally to Console.Out.</summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        public static void LogOutput( string format, params object[] args ) => LogMessage( Console.Out, null, format, args );
        /// <summary>Output a general message to the log and additionally to Console.Out.</summary>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogInfo(string, object[])"/>
        /// <seealso cref="LogWarning(string, object[])"/>
        /// <seealso cref="LogError(string, object[])"/>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        public static void LogOutput( string label, string format, params object[] args ) => LogMessage( Console.Out, label, format, args );

        /// <summary>
        /// Output an informational message to the log and additionally to Console.Out.
        /// The message will be prepended with an INFO label.
        /// </summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogInfo(string, object[])"/>
        public static void LogInfo( object obj ) => LogMessage( Console.Out, "INFO", "{0}", obj );
        /// <summary>
        /// Output an informational message to the log and additionally to Console.Out.
        /// The message will be prepended with an INFO label.
        /// </summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        /// <seealso cref="LogWarning(string, object[])"/>
        /// <seealso cref="LogError(string, object[])"/>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        public static void LogInfo( string format, params object[] args ) => LogMessage( Console.Out, "INFO", format, args );

        /// <summary>
        /// Output a warning message to the log and additionally to Console.Error.
        /// The message will be prepended with a WARN label.
        /// </summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogWarning(string, object[])"/>
        public static void LogWarning( object obj ) => LogMessage( Console.Error, "WARN", "{0}", obj );
        /// <summary>
        /// Output a warning message to the log and additionally to Console.Error.
        /// The message will be prepended with a WARN label.
        /// </summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        /// <seealso cref="LogInfo(string, object[])"/>
        /// <seealso cref="LogError(string, object[])"/>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        public static void LogWarning( string format, params object[] args ) => LogMessage( Console.Error, "WARN", format, args );

        /// <summary>
        /// Output an error message to the log and additionally to Console.Error.
        /// The message will be prepended with an ERROR label.
        /// </summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogError(string, object[])"/>
        public static void LogError( object obj ) => LogMessage( Console.Error, "ERROR", "\n{0}", obj );
        /// <summary>
        /// Output an error message to the log and additionally to Console.Error.
        /// The message will be prepended with an ERROR label.
        /// </summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        /// <seealso cref="LogInfo(string, object[])"/>
        /// <seealso cref="LogWarning(string, object[])"/>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        public static void LogError( string format, params object[] args ) => LogMessage( Console.Error, "ERROR", $"\n{format}", args );


        /// <summary>Output a general message to <see cref="LogStream"/>.</summary>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( object obj ) => LogMessage( null, null, "{0}", obj );
        /// <summary>Output a general message to <see cref="LogStream"/>.</summary>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( string label, object obj ) => LogMessage( null, label, "{0}", obj );
        /// <summary>Output a general message to <see cref="LogStream"/> and <paramref name="tee"/>.</summary>
        /// <param name="tee">A secondary stream to tee the message to.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( TextWriter tee, object obj ) => LogMessage( tee, null, "{0}", obj );
        /// <summary>Output a general message to <see cref="LogStream"/> and <paramref name="tee"/>.</summary>
        /// <param name="tee">A secondary stream to tee the message to. If tee is Console.Out then no label will be prepended to the tee message.</param>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="obj">Any object. The data to output.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( TextWriter tee, string label, object obj ) => LogMessage( tee, label, "{0}", obj );
        /// <summary>Output a general message to <see cref="LogStream"/>.</summary>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( string format, params object[] args ) => LogMessage( null, null, format, args );
        /// <summary>Output a general message to <see cref="LogStream"/>.</summary>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( string label, string format, params object[] args ) => LogMessage( null, label, format, args );
        /// <summary>Output a general message to <see cref="LogStream"/> and <paramref name="tee"/>.</summary>
        /// <param name="tee">A secondary stream to tee the message to.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogMessage(TextWriter, string, string, object[])"/>
        public static void LogMessage( TextWriter tee, string format, params object[] args ) => LogMessage( tee, null, format, args );
        /// <summary>Output a general message to <see cref="LogStream"/> and <paramref name="tee"/>.</summary>
        /// <param name="tee">A secondary stream to tee the message to. If tee is Console.Out then no label will be prepended to the tee message.</param>
        /// <param name="label">A label to prepend to the log message.</param>
        /// <param name="format">A format string that the message will be composed from.</param>
        /// <param name="args">The arguments to be formatted.</param>
        /// <seealso cref="LogOutput(string, string, object[])"/>
        /// <seealso cref="LogInfo(string, object[])"/>
        /// <seealso cref="LogWarning(string, object[])"/>
        /// <seealso cref="LogError(string, object[])"/>
        /// <seealso cref="LogDebug(string, string, string, object[])"/>
        /// <seealso cref="LogTrace(string, string, string, object[])"/>
        public static void LogMessage( TextWriter tee, string label, string format, params object[] args ) {

            label = !string.IsNullOrWhiteSpace( label ) ? $"[{label}]: " : "";

            string[] lines = string.Format( format, args ).Replace( "\r\n", "\n" ).Split( new char[] { '\n' } );

            bool first = true;
            int last = lines.Length - 1;
            for ( int i = 0; i < lines.Length; i++ ) {
                WriteLine( tee, lines[i], GetLabelledLine( label, lines[i], ref first, (i == last) ) );
            }
        }

        private static string GetLabelledLine( string label, string line, ref bool first, bool last ) {
            if ( !first ) return line;
            first = (string.IsNullOrWhiteSpace( line ) && !last);
            return !first ? $"{label}{line}" : line;
        }

        private static void WriteLine( TextWriter tee, string line, string logLine ) {
            tee?.WriteLine( IndentString( (tee == Console.Out) ? line : logLine ) );
            LogStream?.WriteLine( IndentString( logLine ) );
        }

    }

}
