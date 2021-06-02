using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, GUID = 0x1DF09CAF01E518B, NameHash = 0x662E605B574D59AB)]
    public class GcPulseEncounterSpawnConditions : NMSTemplate
    {
        /* 0x00 */ public bool AllowedInCreative;
        /* 0x01 */ public bool AllowedInEmptySystem;
        /* 0x02 */ public bool AllowedDuringTutorial;
        /* 0x03 */ public bool AllowedBeyondPortals;
        /* 0x04 */ public bool AllowedWhileOnMPMission;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x05 */ public byte[] Padding3;
        /* 0x08 */ public NMSString0x10 RequiresProduct;
        /* 0x18 */ public NMSString0x10 RequiresMissionComplete;
        /* 0x28 */ public NMSString0x10 RequiresMissionActive;
        /* 0x38 */ public NMSString0x10 RequiresMissionNotComplete;
        /* 0x48 */ public NMSString0x10 RequiresMissionNotActive;
        /* 0x58 */ public bool RequiresAlienShip;
        /* 0x59 */ public bool StandardEncounter;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x5A */ public byte[] EndPadding;
    }
}
