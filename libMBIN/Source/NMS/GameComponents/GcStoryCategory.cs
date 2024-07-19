using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4847FB4A14DC134E, NameHash = 0x71D0DB49)]
    public class GcStoryCategory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CategoryID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A CategoryIDUpper;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTextureResource IconOff;
        [NMS(Index = 2)]
        /* 0x58 */ public TkTextureResource IconOn;
        [NMS(Index = 4)]
        /* 0x70 */ public List<GcStoryPage> Pages;
    }
}
