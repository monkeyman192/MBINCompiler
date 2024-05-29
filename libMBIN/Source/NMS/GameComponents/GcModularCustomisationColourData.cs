using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB2AFC600CC1C752, NameHash = 0xC3024C94ACDED112)]
    public class GcModularCustomisationColourData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A RequiredTextureOption;
        [NMS(Index = 3)]
        /* 0x20 */ public List<GcModularCustomisationColourGroup> ColourGroups;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 PaletteID;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 RequiredTextureGroup;
    }
}
