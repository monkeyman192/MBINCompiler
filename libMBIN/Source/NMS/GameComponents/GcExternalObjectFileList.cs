using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10D38F8777A51321, NameHash = 0x76D3572C2A9662D2)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 15)]
        /* 0x20 */ public int MaxFilesToChoose;
        [NMS(Index = 14)]
        /* 0x24 */ public int MinFilesToChoose;
        [NMS(Index = 12)]
        /* 0x28 */ public GcBiomeType OnlyOnBiome;
        [NMS(Index = 13)]
        /* 0x2C */ public float ProbabilityOfBeingActive;
        [NMS(Index = 11)]
        /* 0x30 */ public bool ForceOnSeasonStart;
        [NMS(Index = 9)]
        /* 0x31 */ public bool NotOnDeadPlanets;
        [NMS(Index = 6)]
        /* 0x32 */ public bool NotOnExtremePlanets;
        [NMS(Index = 10)]
        /* 0x33 */ public bool NotOnInfested;
        [NMS(Index = 7)]
        /* 0x34 */ public bool NotOnStartPlanets;
        [NMS(Index = 8)]
        /* 0x35 */ public bool NotOnWeirdPlanets;
        [NMS(Index = 3)]
        /* 0x36 */ public bool OnlyOnCorruptSentinels;
        [NMS(Index = 4)]
        /* 0x37 */ public bool OnlyOnDeepWater;
        [NMS(Index = 2)]
        /* 0x38 */ public bool OnlyOnExtremeSentinels;
        [NMS(Index = 1)]
        /* 0x39 */ public bool OnlyOnExtremeWeather;
        [NMS(Index = 5)]
        /* 0x3A */ public bool OnlyOnInfested;
    }
}
