using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x646A0C1191EE257E, NameHash = 0xBCA6917366A88ADB)]
    public class GcWikiCategory : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CategoryID;
        /* 0x020 */ public NMSString0x20A CategoryIDUpper;
        /* 0x040 */ public TkTextureResource IconOn;
        /* 0x0C4 */ public TkTextureResource IconOff;
        /* 0x148 */ public List<GcWikiTopic> Topics;
        /* 0x158 */ public GcWikiTopicType Type;
        /* 0x160 */ public List<NMSString0x10> Items;
        /* 0x170 */ public int UnseenCount;
        /* 0x174 */ public int UnlockedCount;
    }
}
