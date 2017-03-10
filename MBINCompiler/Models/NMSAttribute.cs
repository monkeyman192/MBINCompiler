using System;

namespace MBINCompiler.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter)]
    public class NMSAttribute : Attribute
    {
        public int Size { get; set; }
        public bool Ignore { get; set; }
        public object DefaultValue { get; set; }
        public string[] EnumValue { get; set; }
        public int Padding { get; set; }
    }
}