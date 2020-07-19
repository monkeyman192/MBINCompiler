namespace libMBIN {

    /// <summary>Version Utilities</summary>
    public static class Version {

        // THIS IS THE MASTER VERSION STRING. MAKE VERSION CHANGES HERE.
        // Used by libMBIN.AssemblyInfo, MBINCompiler.AssemblyInfo
        // and (this) libMBIN.Version
        //
        // The format is "Major.Minor.Release.Prerelease"
        //
        // The Major and Minor version numbers should match the NMS version that is supported.
        // The 3rd version number indicates the libMBIN Release version.
        // The 4th version number indicates the libMBIN Pre-Release version.
        //
        // Note that ver X.X.0.0 does not make sense!
        // *.*.0.1 is the first (developement) prerelase
        // *.*.1.0 is the first (master) release
        // Following this convention, the type of release can be determined by the version
        // numbers. If the prerelease version is 0, then it is a master release. Otherwise
        // if the prerelease version is not 0, then the build is a (development) prerelease.
        // 
        // When the Minor version is reset or incremented:
        //      the Release    version should be reset to 0
        //      the Prerelease version should be reset to 1
        // When the Release version is incremented:
        //      the Prerelease version should be reset to 0
        internal const string VERSION_STRING = "2.61.0.1";

        /// <summary>Shorthand for AssemblyVersion.Major</summary>
        public static int Major      => AssemblyVersion.Major;
        /// <summary>Shorthand for AssemblyVersion.Minor</summary>
        public static int Minor      => AssemblyVersion.Minor;
        /// <summary>Shorthand for AssemblyVersion.Build</summary>
        public static int Release    => AssemblyVersion.Build;
        /// <summary>Shorthand for AssemblyVersion.Revision</summary>
        public static int Prerelease => AssemblyVersion.Revision;

        /// <summary>The libMBIN assembly version.</summary>
        public static System.Version AssemblyVersion => new System.Version( VERSION_STRING );

        /// <summary>
        ///     The NMS version that is supported by this assembly.
        ///     (The <see cref="Major"/>, <see cref="Minor"/> and <see cref="Release"/> components of <see cref="AssemblyVersion"/>)
        /// </summary>
        public static System.Version NMSVersion => new System.Version( Major, Minor, Release, 0 );

        /// <summary>
        ///     Returns a human-readable suffix indicating the <see cref="Prerelease"/> version.
        /// </summary>
        /// <returns>
        ///     If the current assembly version is a prerelease (<see cref="Release"/> is 0 or <see cref="Prerelease"/> is not 0) then "-pre{Prerelease}" is returned.
        ///     Otherwise returns an emptry string.
        /// </returns>
        public static string GetSuffix() => (Release == 0 || Prerelease != 0) ? $"-pre{Prerelease}" : "";

        /// <summary>
        ///     Returns the assembly version in a human-readable string format.
        ///     Eg. "1.1.0" (Release) or "1.1.0-pre1" (Pre-Release)
        /// </summary>
        /// <returns>"{<see cref="Major"/>}.{<see cref="Minor"/>}.{<see cref="Release"/>}{<see cref="GetSuffix">Suffix</see>}"</returns>
        public static string GetString() => AssemblyVersion.ToString( 3 ) + GetSuffix();

    }

}
