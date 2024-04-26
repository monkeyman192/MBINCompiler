using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x336C024001BFA1B3, NameHash = 0x814973F0DDEB62C8)]
    public class GcDifficultyStateData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcDifficultySettingsData Settings;
        [NMS(Index = 1)]
        /* 0x58 */ public GcDifficultyPresetType EasiestUsedPreset;
        [NMS(Index = 2)]
        /* 0x5C */ public GcDifficultyPresetType HardestUsedPreset;
        [NMS(Index = 0)]
        /* 0x60 */ public GcDifficultyPresetType Preset;
    }
}
