using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7779185133EF811, NameHash = 0x55D566D2C6EFD1C1)]
    public class GcWikiTopic : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A MissionButtonText;
        /* 0x020 */ public NMSString0x20A ShortDescriptionID;
        /* 0x040 */ public NMSString0x20A TopicID;
        /* 0x060 */ public NMSString0x10 Mission;
        /* 0x070 */ public List<GcWikiPage> Pages;
        /* 0x080 */ public TkTextureResource Icon;
        /* 0x104 */ public TkTextureResource NotifyIcon;
        /* 0x188 */ public GcActionSetType ActionSet;
        /* 0x18C */ public bool Seen;
        /* 0x18D */ public bool Unlocked;
    }
}
