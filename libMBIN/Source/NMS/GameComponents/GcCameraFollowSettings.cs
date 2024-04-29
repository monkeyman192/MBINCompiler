namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB9C2FD249F5899, NameHash = 0x200FDA306DC86654)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 53)]
        /* 0x10 */ public float AvoidCollisionLRSpeed;
        [NMS(Index = 55)]
        /* 0x14 */ public float AvoidCollisionPushSpeed;
        [NMS(Index = 54)]
        /* 0x18 */ public float AvoidCollisionUDSpeed;
        [NMS(Index = 9)]
        /* 0x1C */ public float BackMaxDistance;
        [NMS(Index = 8)]
        /* 0x20 */ public float BackMinDistance;
        [NMS(Index = 10)]
        /* 0x24 */ public float BackSlopeAdjust;
        [NMS(Index = 11)]
        /* 0x28 */ public float BackSlopeRotationAdjust;
        [NMS(Index = 35)]
        /* 0x2C */ public float CenterBlendTime;
        [NMS(Index = 37)]
        /* 0x30 */ public float CenterMaxSpeed;
        [NMS(Index = 36)]
        /* 0x34 */ public float CenterMaxSpring;
        [NMS(Index = 41)]
        /* 0x38 */ public float CenterStartSpeed;
        [NMS(Index = 34)]
        /* 0x3C */ public float CenterStartTime;
        [NMS(Index = 60)]
        /* 0x40 */ public float CustomBlendTime;
        [NMS(Index = 29)]
        /* 0x44 */ public float DistSpeed;
        [NMS(Index = 30)]
        /* 0x48 */ public float DistSpeedOutsideMainRange;
        [NMS(Index = 31)]
        /* 0x4C */ public float DistStiffness;
        [NMS(Index = 21)]
        /* 0x50 */ public float HorizRotationAngleMaxPerFrame;
        [NMS(Index = 16)]
        /* 0x54 */ public float LeftMaxDistance;
        [NMS(Index = 15)]
        /* 0x58 */ public float LeftMinDistance;
        [NMS(Index = 42)]
        /* 0x5C */ public float LookStickLimitAngle;
        [NMS(Index = 46)]
        /* 0x60 */ public float LRProbesRadius;
        [NMS(Index = 45)]
        /* 0x64 */ public float LRProbesRange;
        [NMS(Index = 1)]
        /* 0x68 */ public float MinSpeed;
        [NMS(Index = 44)]
        /* 0x6C */ public int NumLRProbes;
        [NMS(Index = 47)]
        /* 0x70 */ public int NumUDProbes;
        [NMS(Index = 3)]
        /* 0x74 */ public float OffsetX;
        [NMS(Index = 4)]
        /* 0x78 */ public float OffsetY;
        [NMS(Index = 5)]
        /* 0x7C */ public float OffsetYAlt;
        [NMS(Index = 17)]
        /* 0x80 */ public float OffsetYExtraMaxDistance;
        [NMS(Index = 6)]
        /* 0x84 */ public float OffsetYSlopeExtra;
        [NMS(Index = 7)]
        /* 0x88 */ public float OffsetZFlat;
        [NMS(Index = 19)]
        /* 0x8C */ public float PanFar;
        [NMS(Index = 18)]
        /* 0x90 */ public float PanNear;
        [NMS(Index = 49)]
        /* 0x94 */ public float ProbeCenterX;
        [NMS(Index = 50)]
        /* 0x98 */ public float ProbeCenterY;
        [NMS(Index = 51)]
        /* 0x9C */ public float PushForwardDropoffLR;
        [NMS(Index = 52)]
        /* 0xA0 */ public float PushForwardDropoffUD;
        [NMS(Index = 2)]
        /* 0xA4 */ public float SpeedRange;
        [NMS(Index = 32)]
        /* 0xA8 */ public float SpringSpeed;
        [NMS(Index = 48)]
        /* 0xAC */ public float UDProbesRange;
        [NMS(Index = 20)]
        /* 0xB0 */ public float UpGamma;
        [NMS(Index = 13)]
        /* 0xB4 */ public float UpMaxDistance;
        [NMS(Index = 12)]
        /* 0xB8 */ public float UpMinDistance;
        [NMS(Index = 14)]
        /* 0xBC */ public float UpSlopeAdjust;
        [NMS(Index = 38)]
        /* 0xC0 */ public float VelocityAnticipate;
        [NMS(Index = 39)]
        /* 0xC4 */ public float VelocityAnticipateSpringSpeed;
        [NMS(Index = 40)]
        /* 0xC8 */ public float VertMaxSpring;
        [NMS(Index = 24)]
        /* 0xCC */ public float VertRotationMax;
        [NMS(Index = 23)]
        /* 0xD0 */ public float VertRotationMin;
        [NMS(Index = 25)]
        /* 0xD4 */ public float VertRotationOffset;
        [NMS(Index = 27)]
        /* 0xD8 */ public float VertRotationOffsetMaxAngle;
        [NMS(Index = 26)]
        /* 0xDC */ public float VertRotationOffsetMinAngle;
        [NMS(Index = 22)]
        /* 0xE0 */ public float VertRotationSpeed;
        [NMS(Index = 57)]
        /* 0xE4 */ public bool AvoidCollisionLRUseStickDelay;
        [NMS(Index = 56)]
        /* 0xE5 */ public bool AvoidCollisionUDUseStickDelay;
        [NMS(Index = 43)]
        /* 0xE6 */ public bool EnableCollisionDetection;
        [NMS(Index = 33)]
        /* 0xE7 */ public bool LockToObjectOnIdle;
        [NMS(Index = 59)]
        /* 0xE8 */ public bool UseCustomBlendTime;
        [NMS(Index = 58)]
        /* 0xE9 */ public bool UseSpeedBasedSpring;
        [NMS(Index = 28)]
        /* 0xEA */ public bool VertStartLookingDown;
    }
}
