using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x782FBE9D9BD9D467, NameHash = 0xAE3AC9A3967B8330)]
    public class GcDifficultySettingsReplicatedState : NMSTemplate
    {
        /* 0x00 */ public GcDifficultyPresetType EasiestUsedPreset;
        /* 0x04 */ public GcDifficultyPresetType HardestUsedPreset;
        /* 0x08 */ public GcDifficultyPresetType Preset;
        /* 0x0C */ public GcDifficultyPresetType RoundedDownPreset;
        /* 0x10 */ public bool IsLocked;
        /* 0x11 */ public bool IsPermadeath;
    }
}
