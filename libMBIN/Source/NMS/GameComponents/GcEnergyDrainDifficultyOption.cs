namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8110581C7BD94717, NameHash = 0x518EAA1C)]
    public class GcEnergyDrainDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum EnergyDrainDifficultyEnum : uint {
            Slow,
            Normal,
            Fast,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EnergyDrainDifficultyEnum EnergyDrainDifficulty;
    }
}
