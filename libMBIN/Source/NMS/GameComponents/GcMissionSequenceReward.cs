namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3589DA89D687D2BD, NameHash = 0x7471FD77815538C2)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Reward;
        // size: 0x5
        public enum RewardInventoryOverrideEnum : uint {
            None,
            Suit,
            Ship,
            Vehicle,
            Freighter,
        }
        /* 0x010 */ public RewardInventoryOverrideEnum RewardInventoryOverride;
        /* 0x014 */ public NMSString0x80 DebugText;
        /* 0x094 */ public NMSString0x80 Message;
        /* 0x114 */ public bool DoMissionBoardOverride;
        /* 0x115 */ public bool Silent;
    }
}
