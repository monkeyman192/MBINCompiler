using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x168, GUID = 0x592154E96A873769, NameHash = 0xBCA6917366A88ADB)]
    public class GcWikiCategory : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CategoryID;
        /* 0x020 */ public NMSString0x20A CategoryIDUpper;
        /* 0x040 */ public TkTextureResource IconOn;
        /* 0x0C4 */ public TkTextureResource IconOff;
        /* 0x148 */ public List<GcWikiTopic> Topics;
        /* 0x158 */ public GcWikiTopicType Type;
        /* 0x15C */ public int UnseenCount;
        /* 0x160 */ public int UnlockedCount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x164 */ public byte[] EndPadding;
    }
}
