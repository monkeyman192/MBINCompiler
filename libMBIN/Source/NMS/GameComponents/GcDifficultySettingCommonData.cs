using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74589ABFFFA5C0B8, NameHash = 0xA98FDB01046545AD)]
    public class GcDifficultySettingCommonData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A DescriptionLocID;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A TitleLocID;
        [NMS(Index = 6)]
        /* 0x40 */ public NMSString0x20A ToggleDisabledLocID;
        [NMS(Index = 5)]
        /* 0x60 */ public NMSString0x20A ToggleEnabledLocID;
        [NMS(Index = 2)]
        /* 0x80 */ public GcDifficultySettingEditability EditabilityInOptionsMenu;
        [NMS(Index = 0)]
        /* 0x84 */ public GcDifficultySettingType SettingType;
        [NMS(Index = 1)]
        /* 0x88 */ public bool IsAscendingDifficulty;
    }
}
