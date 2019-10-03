using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD0, GUID = 0xCFB68F7E2241F07A, NameHash = 0x55D566D2C6EFD1C1)]
    public class GcWikiTopic : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string TopicID;
        /* 0x20 */ public TkTextureResource Icon;
        /* 0xA8 */ public List<GcWikiPage>  Pages;
        [NMS(Size = 0x10)]
        /* 0xB8 */ public string Mission;
        /* 0xC8 */ public bool Seen;
        /* 0xC9 */ public bool Unlocked;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0xCA */ public byte[] PaddingCA;
        /* 0xCC */ public GcActionSetType ActionSet;
    }
}
