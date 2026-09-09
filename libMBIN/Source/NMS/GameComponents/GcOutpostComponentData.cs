using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA4EE365989DA9AF, NameHash = 0x6F7A12EA)]
    public class GcOutpostComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public NMSString0x10 Door;
        [NMS(Index = 35)]
        /* 0x10 */ public List<GcOutpostLSystemPair> LSystems;
        [NMS(Index = 14)]
        /* 0x20 */ public float ApproachAngle;
        [NMS(Index = 12)]
        /* 0x24 */ public float ApproachNodeTargetOffset;
        [NMS(Index = 13)]
        /* 0x28 */ public float ApproachRange;
        [NMS(Index = 16)]
        /* 0x2C */ public float ApproachSpeed;
        [NMS(Index = 11)]
        /* 0x30 */ public float CircleRadius;
        [NMS(Index = 18)]
        /* 0x34 */ public float CorvetteLandingIndicatorRange;
        [NMS(Index = 20)]
        /* 0x38 */ public float DockingAttractConeAngle;
        [NMS(Index = 21)]
        /* 0x3C */ public float DockingAttractFacingAngle;
        [NMS(Index = 19)]
        /* 0x40 */ public float DockingAttractRange;
        [NMS(Index = 23)]
        /* 0x44 */ public float LandingHeight;
        [NMS(Index = 22)]
        /* 0x48 */ public float LandingSpeed;
        [NMS(Index = 17)]
        /* 0x4C */ public float PlayerAutoLandRange;
        [NMS(Index = 32)]
        /* 0x50 */ public float PostTakeOffExtraPlayerHeight;
        [NMS(Index = 33)]
        /* 0x54 */ public float PostTakeOffExtraPlayerSpeed;
        [NMS(Index = 28)]
        /* 0x58 */ public float TakeOffAlignTime;
        [NMS(Index = 30)]
        /* 0x5C */ public float TakeOffBoost;
        [NMS(Index = 31)]
        /* 0x60 */ public float TakeOffExtraAIHeight;
        [NMS(Index = 26)]
        /* 0x64 */ public float TakeOffFwdDist;
        [NMS(Index = 25)]
        /* 0x68 */ public float TakeOffHeight;
        [NMS(Index = 34)]
        /* 0x6C */ public float TakeOffProgressForExtraHeight;
        [NMS(Index = 29)]
        /* 0x70 */ public float TakeOffSpeed;
        [NMS(Index = 27)]
        /* 0x74 */ public float TakeOffTime;
        [NMS(Index = 5)]
        /* 0x78 */ public bool AbandonedFreighter;
        [NMS(Index = 6)]
        /* 0x79 */ public bool AIDestination;
        [NMS(Index = 0)]
        /* 0x7A */ public bool Anomaly;
        [NMS(Index = 10)]
        /* 0x7B */ public bool CheckLandingAreaClear;
        [NMS(Index = 1)]
        /* 0x7C */ public bool Frigate;
        [NMS(Index = 7)]
        /* 0x7D */ public bool HasDoors;
        [NMS(Index = 8)]
        /* 0x7E */ public bool HasOwnGravity;
        [NMS(Index = 3)]
        /* 0x7F */ public bool NexusExterior;
        [NMS(Index = 4)]
        /* 0x80 */ public bool NexusInterior;
        [NMS(Index = 15)]
        /* 0x81 */ public bool RequireApproachFromAbove;
        [NMS(Index = 24)]
        /* 0x82 */ public bool RotateToDock;
        [NMS(Index = 2)]
        /* 0x83 */ public bool SpaceStation;
        [NMS(Index = 36)]
        /* 0x84 */ public GcSpaceWalkDisallowedComponentData SpaceWalkDisallowedComponentData;
    }
}
