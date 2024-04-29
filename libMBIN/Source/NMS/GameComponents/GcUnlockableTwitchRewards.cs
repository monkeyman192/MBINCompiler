using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35B9BD0B5627AA93, NameHash = 0xF128895FDB533FA8)]
    public class GcUnlockableTwitchRewards : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcUnlockableTwitchReward> Table;
    }
}
