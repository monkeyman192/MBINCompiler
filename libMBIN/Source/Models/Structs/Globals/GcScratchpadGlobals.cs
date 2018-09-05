namespace libMBIN.Models.Structs
{
    public class GcScratchpadGlobals : NMSTemplate
    {
        [NMS(Size = 0xE)]
        /* 0x0 */ public GcPresetTextureData[] IBLMaps;
        [NMS(Size = 0xA)]
        /* 0x1500 */ public GcPresetTextureData[] TerrainTextures;
        [NMS(Size = 0x2)]
        /* 0x2400 */ public GcPresetTextureData[] OverlayTextures;
        [NMS(Size = 0xD)]
        /* 0x2700 */ public Colour[] TerrainColours;
    }
}
