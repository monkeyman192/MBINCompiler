using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x198, GUID = 0xC5BCD08BAB773978, NameHash = 0x4E7A7CEB00A9346B)]
    public class GcTargetMissionSurveyOptions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 TargetMissionSurveyId;
        /* 0x010 */ public bool TargetMissionSurveyDefinitelyExists;
        /* 0x011 */ public NMSString0x80 SurveyInactiveHint;
        /* 0x091 */ public NMSString0x80 SurveySwapHint;
        /* 0x111 */ public NMSString0x80 SurveyHint;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x191 */ public byte[] EndPadding;
    }
}
