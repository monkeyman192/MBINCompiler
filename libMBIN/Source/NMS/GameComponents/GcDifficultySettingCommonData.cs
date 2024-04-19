using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDEDB2FA76A38658, NameHash = 0xA98FDB01046545AD)]
    public class GcDifficultySettingCommonData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A DescriptionLocID;
        /* 0x20 */ public NMSString0x20A TitleLocID;
        /* 0x40 */ public NMSString0x20A ToggleDisabledLocID;
        /* 0x60 */ public NMSString0x20A ToggleEnabledLocID;
        /* 0x80 */ public GcDifficultySettingEditability EditabilityInOptionsMenu;
        /* 0x84 */ public GcDifficultySettingType SettingType;
        /* 0x88 */ public bool IsAscendingDifficulty;
    }
}
