using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x147C0E1692501AE6, NameHash = 0xBCA6917366A88ADB)]
    public class GcWikiCategory : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CategoryID;
        /* 0x020 */ public NMSString0x20A CategoryIDUpper;
        /* 0x040 */ public List<NMSString0x10> Items;
        /* 0x050 */ public List<GcWikiTopic> Topics;
        /* 0x060 */ public TkTextureResource IconOff;
        /* 0x0E4 */ public TkTextureResource IconOn;
        /* 0x168 */ public GcWikiTopicType Type;
        /* 0x16C */ public int UnlockedCount;
        /* 0x170 */ public int UnseenCount;
    }
}
