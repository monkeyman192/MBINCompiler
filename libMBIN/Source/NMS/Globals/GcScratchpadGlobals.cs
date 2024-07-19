using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xC03185E876CED26E, NameHash = 0x8A331269)]
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
