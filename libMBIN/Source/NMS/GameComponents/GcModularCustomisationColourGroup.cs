using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD4FF01CBC738F2E, NameHash = 0x1D283C8E)]
    public class GcModularCustomisationColourGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x20 */ public List<TkPaletteTexture> Palettes;
        [NMS(Index = 1)]
        /* 0x30 */ public int DefaultColourIndex;
    }
}
