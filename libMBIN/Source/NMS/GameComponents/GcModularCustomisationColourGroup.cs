using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44F059B5829C9F8, NameHash = 0x5004C728A88D1AD0)]
    public class GcModularCustomisationColourGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcModularCustomisationColourGroupPalette> Palettes;
        [NMS(Index = 1)]
        /* 0x30 */ public int DefaultColourIndex;
    }
}
