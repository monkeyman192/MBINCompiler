using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3B84F81C9B02B741, NameHash = 0x33CAC73016241300)]
    public class GcJourneyMedal : NMSTemplate
    {
        /* 0x000 */ public GcJourneyMedalType Type;
        /* 0x004 */ public TkTextureResource None;
        /* 0x088 */ public TkTextureResource Bronze;
        /* 0x10C */ public TkTextureResource Silver;
        /* 0x190 */ public TkTextureResource Gold;
    }
}