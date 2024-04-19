using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED6E5432793ED78D, NameHash = 0x184558FBF0A370E2)]
    public class GcOutpostComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Door;
        /* 0x10 */ public List<GcOutpostLSystemPair> LSystems;
        /* 0x20 */ public float ApproachAngle;
        /* 0x24 */ public float ApproachRange;
        /* 0x28 */ public float ApproachSpeed;
        /* 0x2C */ public float CircleRadius;
        /* 0x30 */ public float LandingHeight;
        /* 0x34 */ public float LandingSpeed;
        /* 0x38 */ public float PlayerAutoLandRange;
        /* 0x3C */ public float PostTakeOffExtraPlayerHeight;
        /* 0x40 */ public float PostTakeOffExtraPlayerSpeed;
        /* 0x44 */ public float TakeOffAlignTime;
        /* 0x48 */ public float TakeOffBoost;
        /* 0x4C */ public float TakeOffExtraAIHeight;
        /* 0x50 */ public float TakeOffFwdDist;
        /* 0x54 */ public float TakeOffHeight;
        /* 0x58 */ public float TakeOffProgressForExtraHeight;
        /* 0x5C */ public float TakeOffSpeed;
        /* 0x60 */ public float TakeOffTime;
        /* 0x64 */ public bool AIDestination;
        /* 0x65 */ public bool Anomaly;
        /* 0x66 */ public bool CheckLandingAreaClear;
        /* 0x67 */ public bool Frigate;
        /* 0x68 */ public bool HasDoors;
        /* 0x69 */ public bool HasOwnGravity;
        /* 0x6A */ public bool NexusExterior;
        /* 0x6B */ public bool NexusInterior;
        /* 0x6C */ public bool RotateToDock;
        /* 0x6D */ public bool SpaceStation;
    }
}
