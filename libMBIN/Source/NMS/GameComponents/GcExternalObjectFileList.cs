using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6E9061A1651DC97, NameHash = 0x8710D808)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;
        [NMS(Index = 12)]
        /* 0x10 */ public List<int> ForceOnDuringSeasons;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 14, Size = 0x1C, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x30 */ public float[] SubBiomeProbability;
        [NMS(Index = 17)]
        /* 0xA0 */ public int MaxFilesToChoose;
        [NMS(Index = 16)]
        /* 0xA4 */ public int MinFilesToChoose;
        [NMS(Index = 13)]
        /* 0xA8 */ public GcBiomeType OnlyOnBiome;
        [NMS(Index = 15)]
        /* 0xAC */ public float ProbabilityOfBeingActive;
        [NMS(Index = 11)]
        /* 0xB0 */ public bool ForceOnSeasonStart;
        [NMS(Index = 9)]
        /* 0xB1 */ public bool NotOnDeadPlanets;
        [NMS(Index = 6)]
        /* 0xB2 */ public bool NotOnExtremePlanets;
        [NMS(Index = 10)]
        /* 0xB3 */ public bool NotOnInfested;
        [NMS(Index = 7)]
        /* 0xB4 */ public bool NotOnStartPlanets;
        [NMS(Index = 8)]
        /* 0xB5 */ public bool NotOnWeirdPlanets;
        [NMS(Index = 3)]
        /* 0xB6 */ public bool OnlyOnCorruptSentinels;
        [NMS(Index = 4)]
        /* 0xB7 */ public bool OnlyOnDeepWater;
        [NMS(Index = 2)]
        /* 0xB8 */ public bool OnlyOnExtremeSentinels;
        [NMS(Index = 1)]
        /* 0xB9 */ public bool OnlyOnExtremeWeather;
        [NMS(Index = 5)]
        /* 0xBA */ public bool OnlyOnInfested;
    }
}
