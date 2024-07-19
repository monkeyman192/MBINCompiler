using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCAA8E8909FFD2020, NameHash = 0x2C70ACC)]
    public class TkReplacementResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkTextureResource Original;
        [NMS(Index = 1)]
        /* 0x18 */ public TkTextureResource Replacement;
    }
}
