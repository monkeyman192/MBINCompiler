using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x4AB263BB8D6733B4, NameHash = 0x2B3787F904F75390)]
    public class GcObjectiveTextFormatOptions : NMSTemplate
    {
        /* 0x00 */ public bool ObjectivesCanBeFormattedBySequences;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01 */ public byte[] Padding1;
        /* 0x08 */ public NMSString0x20 FormattableObjective;
        /* 0x28 */ public NMSString0x20 FormattableObjectiveTip;
    }
}
