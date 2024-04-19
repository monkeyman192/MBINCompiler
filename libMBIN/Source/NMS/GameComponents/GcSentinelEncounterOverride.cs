using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x603F80D261BDAEBB, NameHash = 0x858F65761E6CEB71)]
    public class GcSentinelEncounterOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A OSDMessage;
        /* 0x20 */ public NMSString0x20A OSDOnDefeat;
        /* 0x40 */ public NMSString0x20A OSDOnWaveStart;
        /* 0x60 */ public NMSString0x10 ExtremeSpawnID;
        /* 0x70 */ public NMSString0x10 Id;
        /* 0x80 */ public NMSString0x10 SpawnID;
        /* 0x90 */ public NMSString0x10 StatusMessage;
        /* 0xA0 */ public GcRealityGameIcons CustomOSDIcon;
        /* 0xA4 */ public GcEncounterType EncounterTypeOverride;
        /* 0xA8 */ public GcAudioWwiseEvents OSDOnWaveStartAudio;
        /* 0xAC */ public float SummonRadius;
        /* 0xB0 */ public bool EncounterBlocksWantedSpawns;
        /* 0xB1 */ public bool EncounterClearsWantedOnDefeat;
        /* 0xB2 */ public bool IgnoreBuildingCrimesOnDefeat;
        /* 0xB3 */ public bool SpawnsAreAggressive;
        /* 0xB4 */ public bool UseCustomOSDIcon;
        /* 0xB5 */ public bool UseEncounterTypeOverride;
    }
}
