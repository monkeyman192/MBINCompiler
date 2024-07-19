using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C2870F7199F86E5, NameHash = 0x5B8BB381)]
    public class GcWikiTopic : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A MissionButtonText;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A ShortDescriptionID;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x20A TopicID;
        [NMS(Index = 2)]
        /* 0x60 */ public TkTextureResource Icon;
        [NMS(Index = 3)]
        /* 0x78 */ public TkTextureResource NotifyIcon;
        [NMS(Index = 5)]
        /* 0x90 */ public NMSString0x10 Mission;
        [NMS(Index = 4)]
        /* 0xA0 */ public List<GcWikiPage> Pages;
        [NMS(Index = 9)]
        /* 0xB0 */ public GcActionSetType ActionSet;
        [NMS(Index = 7)]
        /* 0xB4 */ public bool Seen;
        [NMS(Index = 8)]
        /* 0xB5 */ public bool Unlocked;
    }
}
