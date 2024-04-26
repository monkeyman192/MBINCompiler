using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x147C0E1692501AE6, NameHash = 0xBCA6917366A88ADB)]
    public class GcWikiCategory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A CategoryID;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A CategoryIDUpper;
        [NMS(Index = 6)]
        /* 0x040 */ public List<NMSString0x10> Items;
        [NMS(Index = 4)]
        /* 0x050 */ public List<GcWikiTopic> Topics;
        [NMS(Index = 3)]
        /* 0x060 */ public TkTextureResource IconOff;
        [NMS(Index = 2)]
        /* 0x0E4 */ public TkTextureResource IconOn;
        [NMS(Index = 5)]
        /* 0x168 */ public GcWikiTopicType Type;
        [NMS(Index = 8)]
        /* 0x16C */ public int UnlockedCount;
        [NMS(Index = 7)]
        /* 0x170 */ public int UnseenCount;
    }
}
