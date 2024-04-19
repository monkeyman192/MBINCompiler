using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A45A2E9AF4C4E10, NameHash = 0x276FB03774F36C9F)]
    public class GcStoryCategory : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CategoryID;
        /* 0x20 */ public NMSString0x20A CategoryIDUpper;
        /* 0x40 */ public List<GcStoryPage> Pages;
        /* 0x50 */ public TkTextureResource IconOff;
        /* 0xD4 */ public TkTextureResource IconOn;
    }
}
