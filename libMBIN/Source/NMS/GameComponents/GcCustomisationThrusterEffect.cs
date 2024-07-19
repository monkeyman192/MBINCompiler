using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC675F3574BE5D20, NameHash = 0x15911543)]
    public class GcCustomisationThrusterEffect : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Colour LightColour;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x20A Tip;
        [NMS(Index = 6)]
        /* 0x30 */ public List<GcCustomisationThrusterJet> Jets;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Name;
        [NMS(Index = 4)]
        /* 0x60 */ public bool AllowedInSeasonalDefaults;
        [NMS(Index = 3)]
        /* 0x61 */ public bool HiddenInCustomiser;
    }
}
