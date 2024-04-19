namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF33D9C6EF3F5AF1, NameHash = 0x200FDA306DC86654)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float AvoidCollisionLRSpeed;
        /* 0x14 */ public float AvoidCollisionPushSpeed;
        /* 0x18 */ public float AvoidCollisionUDSpeed;
        /* 0x1C */ public float BackMaxDistance;
        /* 0x20 */ public float BackMinDistance;
        /* 0x24 */ public float BackSlopeAdjust;
        /* 0x28 */ public float BackSlopeRotationAdjust;
        /* 0x2C */ public float CenterBlendTime;
        /* 0x30 */ public float CenterMaxSpeed;
        /* 0x34 */ public float CenterMaxSpring;
        /* 0x38 */ public float CenterStartSpeed;
        /* 0x3C */ public float CenterStartTime;
        /* 0x40 */ public float CustomBlendTime;
        /* 0x44 */ public float DistSpeed;
        /* 0x48 */ public float DistSpeedOutsideMainRange;
        /* 0x4C */ public float DistStiffness;
        /* 0x50 */ public float HorizRotationAngleMaxPerFrame;
        /* 0x54 */ public float LeftMaxDistance;
        /* 0x58 */ public float LeftMinDistance;
        /* 0x5C */ public float LookStickLimitAngle;
        /* 0x60 */ public float LRProbesRadius;
        /* 0x64 */ public float LRProbesRange;
        /* 0x68 */ public float MinSpeed;
        /* 0x6C */ public int NumLRProbes;
        /* 0x70 */ public int NumUDProbes;
        /* 0x74 */ public float OffsetX;
        /* 0x78 */ public float OffsetY;
        /* 0x7C */ public float OffsetYAlt;
        /* 0x80 */ public float OffsetYExtraMaxDistance;
        /* 0x84 */ public float OffsetYSlopeExtra;
        /* 0x88 */ public float OffsetZFlat;
        /* 0x8C */ public float PanFar;
        /* 0x90 */ public float PanNear;
        /* 0x94 */ public float ProbeCenterX;
        /* 0x98 */ public float ProbeCenterY;
        /* 0x9C */ public float PushForwardDropoffLR;
        /* 0xA0 */ public float PushForwardDropoffUD;
        /* 0xA4 */ public float SpeedRange;
        /* 0xA8 */ public float SpringSpeed;
        /* 0xAC */ public float UDProbesRange;
        /* 0xB0 */ public float UpGamma;
        /* 0xB4 */ public float UpMaxDistance;
        /* 0xB8 */ public float UpMinDistance;
        /* 0xBC */ public float UpSlopeAdjust;
        /* 0xC0 */ public float VelocityAnticipate;
        /* 0xC4 */ public float VelocityAnticipateSpringSpeed;
        /* 0xC8 */ public float VertMaxSpring;
        /* 0xCC */ public float VertRotationMax;
        /* 0xD0 */ public float VertRotationMin;
        /* 0xD4 */ public float VertRotationOffset;
        /* 0xD8 */ public float VertRotationOffsetMaxAngle;
        /* 0xDC */ public float VertRotationOffsetMinAngle;
        /* 0xE0 */ public float VertRotationSpeed;
        /* 0xE4 */ public bool AvoidCollisionLRUseStickDelay;
        /* 0xE5 */ public bool AvoidCollisionUDUseStickDelay;
        /* 0xE6 */ public bool EnableCollisionDetection;
        /* 0xE7 */ public bool LockToObjectOnIdle;
        /* 0xE8 */ public bool UseCustomBlendTime;
        /* 0xE9 */ public bool UseSpeedBasedSpring;
        /* 0xEA */ public bool VertStartLookingDown;
    }
}
