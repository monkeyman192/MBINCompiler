using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0C604F5777777583, NameHash = 0x55D566D2C6EFD1C1)]
    public class GcWikiTopic : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A TopicID;
        /* 0x020 */ public NMSString0x20A ShortDescriptionID;
        /* 0x040 */ public TkTextureResource Icon;
        /* 0x0C4 */ public TkTextureResource NotifyIcon;
        /* 0x148 */ public List<GcWikiPage> Pages;
        /* 0x158 */ public NMSString0x10 Mission;
        /* 0x168 */ public NMSString0x20A MissionButtonText;
        /* 0x188 */ public bool Seen;
        /* 0x189 */ public bool Unlocked;
        /* 0x18C */ public GcActionSetType ActionSet;
    }
}
