using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3793BDDFD87492E1, NameHash = 0x973B907FEECDAE57)]
    public class GcUnlockablePlatformRewards : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcUnlockablePlatformReward> Table;
    }
}
