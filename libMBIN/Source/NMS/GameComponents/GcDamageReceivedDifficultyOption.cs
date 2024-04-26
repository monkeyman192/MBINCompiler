namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9A9869EA0CA2FB, NameHash = 0x9065C0FF676A75B3)]
    public class GcDamageReceivedDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum DamageReceivedDifficultyEnum : uint {
            None,
            Low,
            Normal,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DamageReceivedDifficultyEnum DamageReceivedDifficulty;
    }
}
