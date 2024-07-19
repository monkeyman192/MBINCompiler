using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA224DD9D08B049A3, NameHash = 0xDB0270CB)]
    public class GcUnlockablePlatformRewards : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcUnlockablePlatformReward> Table;
    }
}
