using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31527B2B6DBA26A5, NameHash = 0xB5F28FCF)]
    public class GcDifficultySettingsReplicatedState : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcDifficultyPresetType EasiestUsedPreset;
        [NMS(Index = 4)]
        /* 0x04 */ public GcDifficultyPresetType HardestUsedPreset;
        [NMS(Index = 1)]
        /* 0x08 */ public GcDifficultyPresetType Preset;
        [NMS(Index = 2)]
        /* 0x0C */ public GcDifficultyPresetType RoundedDownPreset;
        [NMS(Index = 5)]
        /* 0x10 */ public bool IsLocked;
        [NMS(Index = 0)]
        /* 0x11 */ public bool IsPermadeath;
    }
}
