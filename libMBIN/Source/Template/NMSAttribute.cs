using System;

namespace libMBIN
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Class)]
    public class NMSAttribute : Attribute
    {
        public int Size { get; set; }
        public bool Ignore { get; set; }
        [Obsolete( "Use EnumType instead." )]
        public string[] EnumValue { get; set; }
        public Type EnumType { get; set; }
        public byte Padding { get; set; }
        public int Alignment { get; set; }
        public ulong GUID { get; set; }
        public ulong NameHash { get; set; }
        public bool Broken { get; set; }
        public bool IDField { get; set; } = false;
        public int Index { get; set; }
    }
}