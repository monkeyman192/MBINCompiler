using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0xB6076343E576F32D, NameHash = 0x4DD6C74BA4B6AD5A)]
    public class GcRewardOpenFreeFreighter : NMSTemplate
    {
        /* 0x00 */ public bool ReinteractWhenBought;
        /* 0x08 */ public NMSString0x20A NextInteractionIfBought;
        /* 0x28 */ public NMSString0x20A NextInteractionIfNotBought;
    }
}
