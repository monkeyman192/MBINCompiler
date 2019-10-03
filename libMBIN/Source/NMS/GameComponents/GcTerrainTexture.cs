using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1E0, GUID = 0x2564BC1E1547197C, NameHash = 0x417FE136A80C6A0A)]
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
