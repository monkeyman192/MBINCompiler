using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2548C70C5DE57F08, NameHash = 0x4CF0C331)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x8)]
        /* 0x000 */ public TkProceduralTextureLayer[] Layers;
        [NMS(Index = 0)]
        /* 0x240 */ public bool AlwaysEnableUnnamedTextureLayers;
    }
}
