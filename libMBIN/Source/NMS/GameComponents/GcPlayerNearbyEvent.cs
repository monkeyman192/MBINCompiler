namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27BC3B6A2294B4C9, NameHash = 0x8A8D7D07807BE9DC)]
    public class GcPlayerNearbyEvent : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x10 MustAffordCostID;
        [NMS(Index = 2)]
        /* 0x10 */ public float Angle;
        [NMS(Index = 6)]
        /* 0x14 */ public float AngleMinDistance;
        [NMS(Index = 4)]
        /* 0x18 */ public float AngleOffset;
        [NMS(Index = 1)]
        /* 0x1C */ public float Distance;
        // size: 0x2
        public enum DistanceCheckTypeEnum : uint {
            Radius,
            BoundingBox,
        }
        [NMS(Index = 8)]
        /* 0x20 */ public DistanceCheckTypeEnum DistanceCheckType;
        // size: 0x6
        public enum RequirePlayerActionEnum : uint {
            None,
            Fire,
            InShip,
            OnFoot,
            OnFootOutside,
            Upload,
        }
        [NMS(Index = 0)]
        /* 0x24 */ public RequirePlayerActionEnum RequirePlayerAction;
        [NMS(Index = 3)]
        /* 0x28 */ public bool AnglePlayerRelative;
        [NMS(Index = 5)]
        /* 0x29 */ public bool AngleReflected;
        [NMS(Index = 11)]
        /* 0x2A */ public bool IncludeAllPhysics;
        [NMS(Index = 12)]
        /* 0x2B */ public bool IncludeMobileNPCs;
        [NMS(Index = 9)]
        /* 0x2C */ public bool Inverse;
        [NMS(Index = 10)]
        /* 0x2D */ public bool OnlyForLocalPlayer;
        [NMS(Index = 13)]
        /* 0x2E */ public bool TeleporterCountsAsPlayer;
    }
}
