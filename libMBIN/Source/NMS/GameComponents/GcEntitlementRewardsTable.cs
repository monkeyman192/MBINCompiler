using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDA2E856096A99DAE, NameHash = 0x1B43FEE74DE674AE)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        public List<GcEntitlementRewardData> Table;
    }
}