using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x51C689949992882A, NameHash = 0xC683578709BD3232)]
    public class TkReplacementResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkTextureResource Original;
        [NMS(Index = 1)]
        /* 0x84 */ public TkTextureResource Replacement;
    }
}
