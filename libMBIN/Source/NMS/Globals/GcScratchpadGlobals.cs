using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xC14472951E47BFF8, NameHash = 0x1BBDA54E462E00C3)]
    public class GcScratchpadGlobals : NMSTemplate
    {
        /* 0x00 */ public List<GcPresetTextureData> IBLMaps;
        /* 0x10 */ public List<GcPresetTextureData> TerrainTextures;
        /* 0x20 */ public List<GcPresetTextureData> OverlayTextures;
        /* 0x30 */ public List<Colour> TerrainColours;
    }
}
