namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B70ED031EA53160, NameHash = 0xFD8A2B15F29A9D3C)]
    public class GcDifficultySettingType : NMSTemplate
    {
        // size: 0x2
        public enum DifficultySettingTypeEnum : uint {
            Toggle,
            OptionList,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DifficultySettingTypeEnum DifficultySettingType;
    }
}
