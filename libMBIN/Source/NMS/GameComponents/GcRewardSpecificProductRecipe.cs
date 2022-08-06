using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B8A7C21F67F359D, NameHash = 0xD0AAAD197E826825)]
    public class GcRewardSpecificProductRecipe : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public bool HideInSeasonRewards;
        /* 0x18 */ public NMSString0x20A SeasonRewardFormat;
    }
}
