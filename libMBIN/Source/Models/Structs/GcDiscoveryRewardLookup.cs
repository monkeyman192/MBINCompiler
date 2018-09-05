using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xF0)]
    public class GcDiscoveryRewardLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Secondary;

        [NMS(Size = 0xD, EnumValue = new string[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        /* 0x20 */ public NMSString0x10[] BiomeSpecific;
    }
}
