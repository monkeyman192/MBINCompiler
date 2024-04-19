namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C709300C9C56203, NameHash = 0x326A8803E3B79519)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A OverrideOSDMessage;
        // size: 0x7
        public enum CombatTypeEnum : uint {
            GroundCombat,
            SpaceCombat,
            FiendCombat,
            BigFishFiendCombat,
            CorruptedSentinelCombat,
            GroundWormCombat,
            RewardEncounter,
        }
        /* 0x20 */ public CombatTypeEnum CombatType;
        /* 0x24 */ public bool CheckAllFireteamMembers;
        /* 0x25 */ public bool EncouragesFightingSentinels;
        /* 0x26 */ public bool SpaceCombatTextCountsPirates;
        /* 0x27 */ public bool SpaceCombatTextCountsSentinels;
    }
}
