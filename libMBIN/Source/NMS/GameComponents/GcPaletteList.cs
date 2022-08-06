using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD30F287F6E810E96, NameHash = 0xDF4A26E5B1BF936A)]
    public class GcPaletteList : NMSTemplate
    {
        [NMS(Size = 0x3A, EnumType = typeof(TkPaletteTexture.PaletteEnum))]
        /* 0x0 */ public GcPaletteData[] Palettes;
    }
}
