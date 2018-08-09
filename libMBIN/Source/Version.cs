namespace libMBIN {

    public static class Version {

        // THIS IS THE MASTER VERSION STRING. MAKE VERSION CHANGES HERE.
        // Used by libMBIN.AssemblyInfo, MBINCompiler.AssemblyInfo
        // and (this) libMBIN.Version
        internal const string VERSION_STRING = "1.55.0.0";

        public static System.Version AssemblyVersion => new System.Version( VERSION_STRING );
        public static System.Version NMSVersion => new System.Version( AssemblyVersion.Major, AssemblyVersion.Minor );

    }

}
