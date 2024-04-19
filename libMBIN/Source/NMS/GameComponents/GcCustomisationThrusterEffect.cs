using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABAF0B001418E0A6, NameHash = 0xE7EC6E83CB496A6C)]
    public class GcCustomisationThrusterEffect : NMSTemplate
    {
        /* 0x00 */ public Colour LightColour;
        /* 0x10 */ public NMSString0x20A Tip;
        /* 0x30 */ public List<GcCustomisationThrusterJet> Jets;
        /* 0x40 */ public NMSString0x10 LinkedSpecialID;
        /* 0x50 */ public NMSString0x10 Name;
        /* 0x60 */ public bool AllowedInSeasonalDefaults;
        /* 0x61 */ public bool HiddenInCustomiser;
    }
}
