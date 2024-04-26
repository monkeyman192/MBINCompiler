using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED6E5432793ED78D, NameHash = 0x184558FBF0A370E2)]
    public class GcOutpostComponentData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public NMSString0x10 Door;
        [NMS(Index = 28)]
        /* 0x10 */ public List<GcOutpostLSystemPair> LSystems;
        [NMS(Index = 12)]
        /* 0x20 */ public float ApproachAngle;
        [NMS(Index = 11)]
        /* 0x24 */ public float ApproachRange;
        [NMS(Index = 13)]
        /* 0x28 */ public float ApproachSpeed;
        [NMS(Index = 10)]
        /* 0x2C */ public float CircleRadius;
        [NMS(Index = 16)]
        /* 0x30 */ public float LandingHeight;
        [NMS(Index = 15)]
        /* 0x34 */ public float LandingSpeed;
        [NMS(Index = 14)]
        /* 0x38 */ public float PlayerAutoLandRange;
        [NMS(Index = 25)]
        /* 0x3C */ public float PostTakeOffExtraPlayerHeight;
        [NMS(Index = 26)]
        /* 0x40 */ public float PostTakeOffExtraPlayerSpeed;
        [NMS(Index = 21)]
        /* 0x44 */ public float TakeOffAlignTime;
        [NMS(Index = 23)]
        /* 0x48 */ public float TakeOffBoost;
        [NMS(Index = 24)]
        /* 0x4C */ public float TakeOffExtraAIHeight;
        [NMS(Index = 19)]
        /* 0x50 */ public float TakeOffFwdDist;
        [NMS(Index = 18)]
        /* 0x54 */ public float TakeOffHeight;
        [NMS(Index = 27)]
        /* 0x58 */ public float TakeOffProgressForExtraHeight;
        [NMS(Index = 22)]
        /* 0x5C */ public float TakeOffSpeed;
        [NMS(Index = 20)]
        /* 0x60 */ public float TakeOffTime;
        [NMS(Index = 5)]
        /* 0x64 */ public bool AIDestination;
        [NMS(Index = 0)]
        /* 0x65 */ public bool Anomaly;
        [NMS(Index = 9)]
        /* 0x66 */ public bool CheckLandingAreaClear;
        [NMS(Index = 1)]
        /* 0x67 */ public bool Frigate;
        [NMS(Index = 6)]
        /* 0x68 */ public bool HasDoors;
        [NMS(Index = 7)]
        /* 0x69 */ public bool HasOwnGravity;
        [NMS(Index = 3)]
        /* 0x6A */ public bool NexusExterior;
        [NMS(Index = 4)]
        /* 0x6B */ public bool NexusInterior;
        [NMS(Index = 17)]
        /* 0x6C */ public bool RotateToDock;
        [NMS(Index = 2)]
        /* 0x6D */ public bool SpaceStation;
    }
}
