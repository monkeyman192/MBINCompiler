using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xB34182CC061DC062, NameHash = 0x1BBDA54E462E00C3)]
    public class GcScratchpadGlobals : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcPresetTextureData> IBLMaps;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcPresetTextureData> OverlayTextures;
        [NMS(Index = 3)]
        /* 0x20 */ public List<Colour> TerrainColours;
        [NMS(Index = 1)]
        /* 0x30 */ public List<GcPresetTextureData> TerrainTextures;
    }
}
