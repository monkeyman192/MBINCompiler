namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF99D3AA654E92C67, NameHash = 0x54BE616E)]
    public class GcFishingDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum FishingDifficultyEnum : uint {
            AutoCatch,
            LongCatchWindow,
            NormalCatchWindow,
            ShortCatchWindow,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FishingDifficultyEnum FishingDifficulty;
    }
}
