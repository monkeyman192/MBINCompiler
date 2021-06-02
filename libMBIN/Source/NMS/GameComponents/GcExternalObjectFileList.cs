using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x1D288621A5B4021B, NameHash = 0x76D3572C2A9662D2)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool OnlyOnExtremeWeather;
        /* 0x11 */ public bool OnlyOnExtremeSentinels;
        /* 0x12 */ public bool OnlyOnDeepWater;
        /* 0x13 */ public bool NotOnExtremePlanets;
        /* 0x14 */ public bool NotOnStartPlanets;
        /* 0x15 */ public bool NotOnWeirdPlanets;
        /* 0x16 */ public bool NotOnDeadPlanets;
        /* 0x18 */ public GcBiomeType OnlyOnBiome;
        /* 0x1C */ public float ProbabilityOfBeingActive;
        /* 0x20 */ public int MinFilesToChoose;
        /* 0x24 */ public int MaxFilesToChoose;
        /* 0x28 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;

    }
}
