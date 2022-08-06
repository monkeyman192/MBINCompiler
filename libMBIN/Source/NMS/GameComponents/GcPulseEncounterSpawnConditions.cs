using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA0B6E598870688E, NameHash = 0x662E605B574D59AB)]
    public class GcPulseEncounterSpawnConditions : NMSTemplate
    {
        /* 0x00 */ public bool AllowedInCreative;
        /* 0x01 */ public bool AllowedInEmptySystem;
        /* 0x02 */ public bool AllowedDuringTutorial;
        /* 0x03 */ public bool AllowedBeyondPortals;
        /* 0x04 */ public bool AllowedWhileOnMPMission;
        /* 0x08 */ public NMSString0x10 RequiresProduct;
        /* 0x18 */ public NMSString0x10 RequiresMissionComplete;
        /* 0x28 */ public NMSString0x10 RequiresMissionActive;
        /* 0x38 */ public NMSString0x10 RequiresMissionNotComplete;
        /* 0x48 */ public NMSString0x10 RequiresMissionNotActive;
        /* 0x58 */ public bool RequiresAlienShip;
        /* 0x59 */ public bool StandardEncounter;
        /* 0x5A */ public bool MissionEncounter;
    }
}
