using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4C4E60D75EC7BFD, NameHash = 0x76D3572C2A9662D2)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        /* 0x00 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;
        /* 0x10 */ public NMSString0x10 Id;
        /* 0x20 */ public int MaxFilesToChoose;
        /* 0x24 */ public int MinFilesToChoose;
        /* 0x28 */ public GcBiomeType OnlyOnBiome;
        /* 0x2C */ public float ProbabilityOfBeingActive;
        /* 0x30 */ public bool ForceOnSeasonStart;
        /* 0x31 */ public bool NotOnDeadPlanets;
        /* 0x32 */ public bool NotOnExtremePlanets;
        /* 0x33 */ public bool NotOnInfested;
        /* 0x34 */ public bool NotOnStartPlanets;
        /* 0x35 */ public bool NotOnWeirdPlanets;
        /* 0x36 */ public bool OnlyOnCorruptSentinels;
        /* 0x37 */ public bool OnlyOnDeepWater;
        /* 0x38 */ public bool OnlyOnExtremeSentinels;
        /* 0x39 */ public bool OnlyOnExtremeWeather;
        /* 0x3A */ public bool OnlyOnInfested;
    }
}
