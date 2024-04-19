using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x847AD74F7FB3EAE9, NameHash = 0xDA4CC10DF6E92F8C)]
    public class GcStoryPage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ID;
        /* 0x20 */ public List<GcStoryEntry> Entries;
        /* 0x30 */ public NMSString0x10 Stat;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public GcInteractionType InteractionType;
        /* 0xC8 */ public GcWikiTopicType WikiGridType;
        /* 0xCC */ public bool StatIsBitmask;
        /* 0xCD */ public bool UseGridType;
    }
}
