using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DF4794AC433DB3C, NameHash = 0x1B43FEE74DE674AE)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcEntitlementRewardData> Table;
    }
}
