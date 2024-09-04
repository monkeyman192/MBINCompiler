using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB47E1FB37AF49475, NameHash = 0xC2A84DBE)]
    public class GcSentinelEncounterOverride : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 9)]
        /* 0x20 */ public NMSString0x20A OSDOnDefeat;
        [NMS(Index = 10)]
        /* 0x40 */ public NMSString0x20A OSDOnWaveStart;
        [NMS(Index = 3)]
        /* 0x60 */ public NMSString0x10 ExtremeSpawnID;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x80 */ public NMSString0x10 SpawnID;
        [NMS(Index = 14)]
        /* 0x90 */ public NMSString0x10 StatusMessage;
        [NMS(Index = 13)]
        /* 0xA0 */ public GcRealityGameIcons CustomOSDIcon;
        [NMS(Index = 16)]
        /* 0xA4 */ public GcEncounterType EncounterTypeOverride;
        [NMS(Index = 11)]
        /* 0xA8 */ public GcAudioWwiseEvents OSDOnWaveStartAudio;
        [NMS(Index = 1)]
        /* 0xAC */ public float SummonRadius;
        [NMS(Index = 5)]
        /* 0xB0 */ public bool EncounterBlocksWantedSpawns;
        [NMS(Index = 6)]
        /* 0xB1 */ public bool EncounterClearsWantedOnDefeat;
        [NMS(Index = 7)]
        /* 0xB2 */ public bool IgnoreBuildingCrimesOnDefeat;
        [NMS(Index = 4)]
        /* 0xB3 */ public bool SpawnsAreAggressive;
        [NMS(Index = 12)]
        /* 0xB4 */ public bool UseCustomOSDIcon;
        [NMS(Index = 15)]
        /* 0xB5 */ public bool UseEncounterTypeOverride;
    }
}
