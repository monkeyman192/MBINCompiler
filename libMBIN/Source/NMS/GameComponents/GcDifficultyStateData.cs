using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x336C024001BFA1B3, NameHash = 0x814973F0DDEB62C8)]
    public class GcDifficultyStateData : NMSTemplate
    {
        /* 0x00 */ public GcDifficultySettingsData Settings;
        /* 0x58 */ public GcDifficultyPresetType EasiestUsedPreset;
        /* 0x5C */ public GcDifficultyPresetType HardestUsedPreset;
        /* 0x60 */ public GcDifficultyPresetType Preset;
    }
}
