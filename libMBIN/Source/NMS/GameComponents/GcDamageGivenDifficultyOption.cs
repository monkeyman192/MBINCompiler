namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x589112860941268A, NameHash = 0x5D3ABB27)]
    public class GcDamageGivenDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum DamageGivenDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DamageGivenDifficultyEnum DamageGivenDifficulty;
    }
}
