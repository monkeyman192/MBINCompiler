using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B020B2EA6A656EE, NameHash = 0x1B43FEE74DE674AE)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcEntitlementRewardData> Table;
    }
}
