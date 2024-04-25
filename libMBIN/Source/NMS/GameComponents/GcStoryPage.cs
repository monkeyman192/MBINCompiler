using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x847AD74F7FB3EAE9, NameHash = 0xDA4CC10DF6E92F8C)]
    public class GcStoryPage : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 5)]
        /* 0x20 */ public List<GcStoryEntry> Entries;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 Stat;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Index = 0)]
        /* 0xC4 */ public GcInteractionType InteractionType;
        [NMS(Index = 7)]
        /* 0xC8 */ public GcWikiTopicType WikiGridType;
        [NMS(Index = 2)]
        /* 0xCC */ public bool StatIsBitmask;
        [NMS(Index = 6)]
        /* 0xCD */ public bool UseGridType;
    }
}
