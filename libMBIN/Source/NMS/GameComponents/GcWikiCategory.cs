using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAA7081CC7C060E4, NameHash = 0x8CDD67C0)]
    public class GcWikiCategory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CategoryID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A CategoryIDUpper;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTextureResource IconOff;
        [NMS(Index = 2)]
        /* 0x58 */ public TkTextureResource IconOn;
        [NMS(Index = 6)]
        /* 0x70 */ public List<NMSString0x10> Items;
        [NMS(Index = 4)]
        /* 0x80 */ public List<GcWikiTopic> Topics;
        [NMS(Index = 5)]
        /* 0x90 */ public GcWikiTopicType Type;
        [NMS(Index = 8)]
        /* 0x94 */ public int UnlockedCount;
        [NMS(Index = 7)]
        /* 0x98 */ public int UnseenCount;
    }
}
