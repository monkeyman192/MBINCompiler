using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21426C55978D18F8, NameHash = 0xDBD890CF58AC39B5)]
    public class GcTileTypeOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkPaletteTexture> Options;
    }
}
