using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFBD6EA952BB287E1, NameHash = 0x8EE3EC0791BD99B7)]
    public class GcRewardUpgradeWeaponClass : NMSTemplate
    {
        public bool Silent;
        public bool MatchClassToCommunityTier;
    }
}
