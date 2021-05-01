using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x68, Alignment = 0x8, GUID = 0x7B02CE1010B72306, NameHash = 0x184558FBF0A370E2)]
    public class GcOutpostComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Anomaly;
        /* 0x01 */ public bool Frigate;
        /* 0x02 */ public bool SpaceStation;
        /* 0x03 */ public bool NexusExterior;
        /* 0x04 */ public bool NexusInterior;
        /* 0x05 */ public bool AIDestination;
        /* 0x06 */ public bool HasDoors;
        /* 0x07 */ public bool HasOwnGravity;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Door;
        /* 0x18 */ public bool CheckLandingAreaClear;
        /* 0x1C */ public float CircleRadius;
        /* 0x20 */ public float ApproachRange;
        /* 0x24 */ public float ApproachAngle;
        /* 0x28 */ public float ApproachSpeed;
        /* 0x2C */ public float PlayerAutoLandRange;
        /* 0x30 */ public float LandingSpeed;
        /* 0x34 */ public float LandingHeight;
        /* 0x38 */ public bool RotateToDock;
        /* 0x3C */ public float TakeOffHeight;
        /* 0x40 */ public float TakeOffFwdDist;
        /* 0x44 */ public float TakeOffTime;
        /* 0x48 */ public float TakeOffAlignTime;
        /* 0x4C */ public float TakeOffSpeed;
        /* 0x50 */ public float TakeOffBoost;
        /* 0x54 */ public float TakeOffExtraAIHeight;
        /* 0x58 */ public List<GcOutpostLSystemPair> LSystems;
    }
}
