using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1044497253969465, NameHash = 0x858F65761E6CEB71)]
    public class GcSentinelEncounterOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float SummonRadius;
        /* 0x18 */ public NMSString0x10 SpawnID;
        /* 0x28 */ public NMSString0x10 ExtremeSpawnID;
        /* 0x38 */ public bool SpawnsAreAggressive;
        /* 0x39 */ public bool EncounterBlocksWantedSpawns;
        /* 0x3A */ public bool EncounterClearsWantedOnDefeat;
        /* 0x3B */ public bool IgnoreBuildingCrimesOnDefeat;
        /* 0x40 */ public NMSString0x20A OSDMessage;
        /* 0x60 */ public NMSString0x20A OSDOnDefeat;
        /* 0x80 */ public NMSString0x20A OSDOnWaveStart;
        /* 0xA0 */ public GcAudioWwiseEvents OSDOnWaveStartAudio;
        /* 0xA4 */ public bool UseCustomOSDIcon;
        /* 0xA8 */ public GcRealityGameIcons CustomOSDIcon;
        /* 0xB0 */ public NMSString0x10 StatusMessage;
        /* 0xC0 */ public bool UseEncounterTypeOverride;
        /* 0xC4 */ public GcEncounterType EncounterTypeOverride;
    }
}
