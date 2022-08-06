using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD29C8914DE73E509, NameHash = 0xF9B9838B50251311)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        /* 0x0 */ public TkPaletteTexture Palette;
        /* 0x8 */ public int Index;
    }
}
