using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7779185133EF811, NameHash = 0x55D566D2C6EFD1C1)]
    public class GcWikiTopic : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public NMSString0x20A MissionButtonText;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A ShortDescriptionID;
        [NMS(Index = 0)]
        /* 0x040 */ public NMSString0x20A TopicID;
        [NMS(Index = 5)]
        /* 0x060 */ public NMSString0x10 Mission;
        [NMS(Index = 4)]
        /* 0x070 */ public List<GcWikiPage> Pages;
        [NMS(Index = 2)]
        /* 0x080 */ public TkTextureResource Icon;
        [NMS(Index = 3)]
        /* 0x104 */ public TkTextureResource NotifyIcon;
        [NMS(Index = 9)]
        /* 0x188 */ public GcActionSetType ActionSet;
        [NMS(Index = 7)]
        /* 0x18C */ public bool Seen;
        [NMS(Index = 8)]
        /* 0x18D */ public bool Unlocked;
    }
}
