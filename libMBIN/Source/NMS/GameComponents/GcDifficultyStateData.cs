using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF7FA79ACCD75243, NameHash = 0x3A5178A6)]
    public class GcDifficultyStateData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcDifficultySettingsData Settings;
        [NMS(Index = 1)]
        /* 0x5C */ public GcDifficultyPresetType EasiestUsedPreset;
        [NMS(Index = 2)]
        /* 0x60 */ public GcDifficultyPresetType HardestUsedPreset;
        [NMS(Index = 0)]
        /* 0x64 */ public GcDifficultyPresetType Preset;
    }
}
