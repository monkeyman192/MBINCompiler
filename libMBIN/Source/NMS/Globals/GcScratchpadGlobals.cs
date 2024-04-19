using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xB34182CC061DC062, NameHash = 0x1BBDA54E462E00C3)]
    public class GcScratchpadGlobals : NMSTemplate
    {
        /* 0x00 */ public List<GcPresetTextureData> IBLMaps;
        /* 0x10 */ public List<GcPresetTextureData> OverlayTextures;
        /* 0x20 */ public List<Colour> TerrainColours;
        /* 0x30 */ public List<GcPresetTextureData> TerrainTextures;
    }
}
