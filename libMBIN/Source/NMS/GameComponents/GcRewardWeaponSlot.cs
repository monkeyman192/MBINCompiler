using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB14B995BBE187BB1, NameHash = 0xC64F181FDA941A39)]
    public class GcRewardWeaponSlot : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Cost;
        /* 0x10 */ public bool AwardCostAndOpenWindow;
        /* 0x14 */ public int NumTokens;
    }
}
