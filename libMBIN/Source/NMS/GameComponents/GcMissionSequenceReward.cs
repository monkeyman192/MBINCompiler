namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AE9F86C02AE363E, NameHash = 0xFFEA5779)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Reward;
        // size: 0x5
        public enum RewardInventoryOverrideEnum : uint {
            None,
            Suit,
            Ship,
            Vehicle,
            Freighter,
        }
        [NMS(Index = 4)]
        /* 0x30 */ public RewardInventoryOverrideEnum RewardInventoryOverride;
        [NMS(Index = 2)]
        /* 0x34 */ public bool DoMissionBoardOverride;
        [NMS(Index = 3)]
        /* 0x35 */ public bool Silent;
    }
}
