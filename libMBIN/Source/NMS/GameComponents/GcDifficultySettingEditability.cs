namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEE62246904BB76D, NameHash = 0x7EC9FDF5)]
    public class GcDifficultySettingEditability : NMSTemplate
    {
        // size: 0x5
        public enum DifficultySettingEditabilityEnum : uint {
            FullyEditable,
            IncreaseOnly,
            DecreaseOnly,
            LockedVisible,
            LockedHidden,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DifficultySettingEditabilityEnum DifficultySettingEditability;
    }
}
