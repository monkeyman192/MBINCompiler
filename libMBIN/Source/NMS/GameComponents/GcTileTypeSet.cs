using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC940DA4B0BE8A4BB, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        [NMS(Size = 0xC)]
        /* 0x4 */ public TkPaletteTexture[] Colours;
    }
}
