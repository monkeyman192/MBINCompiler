using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB3436F89CA8CD87, NameHash = 0x417FE136A80C6A0A)]
    public class GcTerrainTexture : NMSTemplate
    {
        [NMS(Size = 0xC)]
        /* 0x000 */ public GcTerrainTextureSettings[] TextureConfig;
        /* 0x090 */ public NMSString0x80 DiffuseTexture;
        /* 0x110 */ public NMSString0x80 NormalMap;
    }
}
