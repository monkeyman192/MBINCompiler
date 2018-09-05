using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1E0)]
    public class GcTerrainTexture : NMSTemplate      // size: 0x400
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DiffuseTexture;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string NormalMap;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string OverlayTexture;
        [NMS(Size = 0xC)]
        /* 0x180 */ public GcTerrainTextureSettings[] TextureConfig;
    }
}
