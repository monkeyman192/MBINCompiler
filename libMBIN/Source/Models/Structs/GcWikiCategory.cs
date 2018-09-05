using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x168)]
    public class GcWikiCategory : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string CategoryID;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string CategoryIDUpper;
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
