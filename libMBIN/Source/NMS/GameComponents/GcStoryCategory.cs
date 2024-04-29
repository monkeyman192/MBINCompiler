using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EC0314738ED8C92, NameHash = 0x276FB03774F36C9F)]
    public class GcStoryCategory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CategoryID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A CategoryIDUpper;
        [NMS(Index = 4)]
        /* 0x40 */ public List<GcStoryPage> Pages;
        [NMS(Index = 3)]
        /* 0x50 */ public TkTextureResource IconOff;
        [NMS(Index = 2)]
        /* 0xD4 */ public TkTextureResource IconOn;
    }
}
