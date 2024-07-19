using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6F00E77E8DBD77D, NameHash = 0x2D97A37D)]
    public class GcMissionConditionSeasonRewardRedemptionState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSaveContextQuery CurrentContext;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSeasonEndRewardsRedemptionState RewardRedempionState;
    }
}
