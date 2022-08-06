using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x103D15F422AFC306, NameHash = 0x227F6003863B9E93)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        /* 0x0 */ public bool ImmediatelyHatchable;
        /* 0x8 */ public GcPetData EggData;
    }
}
