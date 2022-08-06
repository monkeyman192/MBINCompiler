using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8DC56F5A8F7E32E4, NameHash = 0x417FE136A80C6A0A)]
    public class GcTerrainTexture : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 DiffuseTexture;
        /* 0x080 */ public NMSString0x80 NormalMap;
        [NMS(Size = 0xC)]
        /* 0x100 */ public GcTerrainTextureSettings[] TextureConfig;
    }
}
