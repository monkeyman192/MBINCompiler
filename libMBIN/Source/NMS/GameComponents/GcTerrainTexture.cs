using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF628DA67CA42E58, NameHash = 0x417FE136A80C6A0A)]
    public class GcTerrainTexture : NMSTemplate
    {
        [NMS(Index = 2, Size = 0xC)]
        /* 0x000 */ public GcTerrainTextureSettings[] TextureConfig;
        [NMS(Index = 0)]
        /* 0x090 */ public NMSString0x80 DiffuseTexture;
        [NMS(Index = 1)]
        /* 0x110 */ public NMSString0x80 NormalMap;
    }
}
