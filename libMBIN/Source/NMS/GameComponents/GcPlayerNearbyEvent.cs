namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27BC3B6A2294B4C9, NameHash = 0x8A8D7D07807BE9DC)]
    public class GcPlayerNearbyEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MustAffordCostID;
        /* 0x10 */ public float Angle;
        /* 0x14 */ public float AngleMinDistance;
        /* 0x18 */ public float AngleOffset;
        /* 0x1C */ public float Distance;
        // size: 0x2
        public enum DistanceCheckTypeEnum : uint {
            Radius,
            BoundingBox,
        }
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
        /* 0x24 */ public RequirePlayerActionEnum RequirePlayerAction;
        /* 0x28 */ public bool AnglePlayerRelative;
        /* 0x29 */ public bool AngleReflected;
        /* 0x2A */ public bool IncludeAllPhysics;
        /* 0x2B */ public bool IncludeMobileNPCs;
        /* 0x2C */ public bool Inverse;
        /* 0x2D */ public bool OnlyForLocalPlayer;
        /* 0x2E */ public bool TeleporterCountsAsPlayer;
    }
}
