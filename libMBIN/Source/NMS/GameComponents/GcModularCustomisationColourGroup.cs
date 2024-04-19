using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44F059B5829C9F8, NameHash = 0x5004C728A88D1AD0)]
    public class GcModularCustomisationColourGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public List<GcModularCustomisationColourGroupPalette> Palettes;
        /* 0x30 */ public int DefaultColourIndex;
    }
}
