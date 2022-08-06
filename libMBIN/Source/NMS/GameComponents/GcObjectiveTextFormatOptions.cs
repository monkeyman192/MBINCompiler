using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AB263BB8D6733B4, NameHash = 0x2B3787F904F75390)]
    public class GcObjectiveTextFormatOptions : NMSTemplate
    {
        /* 0x00 */ public bool ObjectivesCanBeFormattedBySequences;
        /* 0x08 */ public NMSString0x20A FormattableObjective;
        /* 0x28 */ public NMSString0x20A FormattableObjectiveTip;
    }
}
