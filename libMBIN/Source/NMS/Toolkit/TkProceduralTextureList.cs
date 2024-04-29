using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB1803D9C82B614C8, NameHash = 0xBEE79269D7359654)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8)]
        /* 0x0 */ public TkProceduralTextureLayer[] Layers;
    }
}
