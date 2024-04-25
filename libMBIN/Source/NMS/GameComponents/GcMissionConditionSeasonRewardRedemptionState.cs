using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC42AFEC01F54DF2B, NameHash = 0x33E6F9E7246B91A7)]
    public class GcMissionConditionSeasonRewardRedemptionState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSaveContextQuery CurrentContext;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSeasonEndRewardsRedemptionState RewardRedempionState;
    }
}
