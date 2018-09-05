namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xE0)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        [NMS(Size =  0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public float MinSpeed;
        /* 0x14 */ public float SpeedRange;
        /* 0x18 */ public float OffsetX;
        /* 0x1C */ public float OffsetY;
        /* 0x20 */ public float OffsetZFlat;
        /* 0x24 */ public float BackMinDistance;
        /* 0x28 */ public float UpMinDistance;
        /* 0x2C */ public float BackMaxDistance;
        /* 0x30 */ public float UpMaxDistance;
        /* 0x34 */ public float PanNear;
        /* 0x38 */ public float PanFar;
        /* 0x3C */ public float UpGamma;
        /* 0x40 */ public float HorizRotationAngleMaxPerFrame;
        /* 0x44 */ public float VertRotationSpeed;
        /* 0x48 */ public float VertRotationMin;
        /* 0x4C */ public float VertRotationMax;
        /* 0x50 */ public float VertRotationOffset;
        /* 0x54 */ public float VertRotationOffsetMinAngle;
        /* 0x58 */ public float VertRotationOffsetMaxAngle;
        /* 0x5C */ public bool VertStartLookingDown;
        /* 0x60 */ public float DistSpeed;
        /* 0x64 */ public float DistSpeedOutsideMainRange;
        /* 0x68 */ public float DistStiffness;
        /* 0x6C */ public float SpringSpeed;
        /* 0x70 */ public bool LockToObjectOnIdle;
        /* 0x74 */ public float CenterStartTime;
        /* 0x78 */ public float CenterBlendTime;
        /* 0x7C */ public float CenterMaxSpring;
        /* 0x80 */ public float CenterMaxSpeed;
        /* 0x84 */ public float VelocityAnticipate;
        /* 0x88 */ public float VelocityAnticipateSpringSpeed;
        /* 0x8C */ public float VertMaxSpring;
        /* 0x90 */ public float CenterStartSpeed;
        /* 0x94 */ public float MinClose;
        /* 0x98 */ public float MaxClose;
        /* 0x9C */ public float CloseSpring;
        /* 0xA0 */ public float LookStickLimitAngle;
        /* 0xA4 */ public bool EnableCollisionDetection;
        /* 0xA8 */ public int NumLRProbes;
        /* 0xAC */ public float LRProbesRange;
        /* 0xB0 */ public float LRProbesRadius;
        /* 0xB4 */ public int NumUDProbes;
        /* 0xB8 */ public float UDProbesRange;
        /* 0xBC */ public float ProbeCenterX;
        /* 0xC0 */ public float ProbeCenterY;
        /* 0xC4 */ public float PushForwardDropoffLR;
        /* 0xC8 */ public float PushForwardDropoffUD;
        /* 0xCC */ public float AvoidCollisionLRSpeed;
        /* 0xD0 */ public float AvoidCollisionUDSpeed;
        /* 0xD4 */ public float AvoidCollisionPushSpeed;
        /* 0xD8 */ public bool AvoidCollisionUDUseStickDelay;
        /* 0xD9 */ public bool AvoidCollisionLRUseStickDelay;
        /* 0xDA */ public bool UseSpeedBasedSpring;

        [NMS(Size = 0x5, Ignore = true)]
        public byte[] EndPadding;
    }
}
