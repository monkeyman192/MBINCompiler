using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7960B9EC2BE7BA8C, NameHash = 0x78571124)]
    public class GcStoryPage : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 3)]
        /* 0x20 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0x38 */ public List<GcStoryEntry> Entries;
        [NMS(Index = 1)]
        /* 0x48 */ public NMSString0x10 Stat;
        [NMS(Index = 0)]
        /* 0x58 */ public GcInteractionType InteractionType;
        [NMS(Index = 7)]
        /* 0x5C */ public GcWikiTopicType WikiGridType;
        [NMS(Index = 2)]
        /* 0x60 */ public bool StatIsBitmask;
        [NMS(Index = 6)]
        /* 0x61 */ public bool UseGridType;
    }
}
