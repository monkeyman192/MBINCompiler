using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4E21A9ABA17459C, NameHash = 0x3911154D)]
    public class GcUnlockableTwitchRewards : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcUnlockableTwitchReward> Table;
    }
}
