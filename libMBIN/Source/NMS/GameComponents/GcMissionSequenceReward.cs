namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3589DA89D687D2BD, NameHash = 0x7471FD77815538C2)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 Reward;
        // size: 0x5
        public enum RewardInventoryOverrideEnum : uint {
            None,
            Suit,
            Ship,
            Vehicle,
            Freighter,
        }
        [NMS(Index = 4)]
        /* 0x010 */ public RewardInventoryOverrideEnum RewardInventoryOverride;
        [NMS(Index = 5)]
        /* 0x014 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x094 */ public NMSString0x80 Message;
        [NMS(Index = 2)]
        /* 0x114 */ public bool DoMissionBoardOverride;
        [NMS(Index = 3)]
        /* 0x115 */ public bool Silent;
    }
}
