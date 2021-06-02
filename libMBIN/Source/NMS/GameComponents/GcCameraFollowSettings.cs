using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0xA9061708E46005BD, NameHash = 0x200FDA306DC86654)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float MinSpeed;
        /* 0x14 */ public float SpeedRange;
        [NMSDescription("Horizontal offset relative to the center (0). Negative values move the camera left, positive values move it right")]
        /* 0x18 */ public float OffsetX;
        [NMSDescription("Vertical offset relative to the center (0). Negative values lower the camera, positive values raise it")]
        /* 0x1C */ public float OffsetY;
        /* 0x20 */ public float OffsetYAlt;
        /* 0x24 */ public float OffsetYSlopeExtra;
        /* 0x28 */ public float OffsetZFlat;
        /* 0x2C */ public float BackMinDistance;
        /* 0x30 */ public float BackMaxDistance;
        /* 0x34 */ public float BackSlopeAdjust;
        /* 0x38 */ public float BackSlopeRotationAdjust;
        /* 0x3C */ public float UpMinDistance;
        /* 0x40 */ public float UpMaxDistance;
        /* 0x44 */ public float UpSlopeAdjust;
        /* 0x48 */ public float LeftMinDistance;
        /* 0x4C */ public float LeftMaxDistance;
        /* 0x50 */ public float PanNear;
        /* 0x54 */ public float PanFar;
        /* 0x58 */ public float UpGamma;
        /* 0x5C */ public float HorizRotationAngleMaxPerFrame;
        /* 0x60 */ public float VertRotationSpeed;
        /* 0x64 */ public float VertRotationMin;
        /* 0x68 */ public float VertRotationMax;
        /* 0x6C */ public float VertRotationOffset;
        /* 0x70 */ public float VertRotationOffsetMinAngle;
        /* 0x74 */ public float VertRotationOffsetMaxAngle;
        /* 0x78 */ public bool VertStartLookingDown;
        /* 0x7C */ public float DistSpeed;
        /* 0x80 */ public float DistSpeedOutsideMainRange;
        /* 0x84 */ public float DistStiffness;
        /* 0x88 */ public float SpringSpeed;
        /* 0x8C */ public bool LockToObjectOnIdle;
        /* 0x90 */ public float CenterStartTime;
        /* 0x94 */ public float CenterBlendTime;
        /* 0x98 */ public float CenterMaxSpring;
        /* 0x9C */ public float CenterMaxSpeed;
        /* 0xA0 */ public float VelocityAnticipate;
        /* 0xA4 */ public float VelocityAnticipateSpringSpeed;
        /* 0xA8 */ public float VertMaxSpring;
        /* 0xAC */ public float CenterStartSpeed;
        /* 0xB0 */ public float MinClose;
        /* 0xB4 */ public float MaxClose;
        /* 0xB8 */ public float CloseSpring;
        /* 0xBC */ public float LookStickLimitAngle;
        [NMSDescription("Specifies whether the camera should collide with the world. Setting to False will make the camera clip through objects and the ground")]
        /* 0xC0 */ public bool EnableCollisionDetection;
        /* 0xC4 */ public int NumLRProbes;
        /* 0xC8 */ public float LRProbesRange;
        /* 0xCC */ public float LRProbesRadius;
        /* 0xD0 */ public int NumUDProbes;
        /* 0xD4 */ public float UDProbesRange;
        /* 0xD8 */ public float ProbeCenterX;
        /* 0xDC */ public float ProbeCenterY;
        /* 0xE0 */ public float PushForwardDropoffLR;
        /* 0xE4 */ public float PushForwardDropoffUD;
        /* 0xE8 */ public float AvoidCollisionLRSpeed;
        /* 0xEC */ public float AvoidCollisionUDSpeed;
        /* 0xF0 */ public float AvoidCollisionPushSpeed;
        /* 0xF4 */ public bool AvoidCollisionUDUseStickDelay;
        /* 0xF5 */ public bool AvoidCollisionLRUseStickDelay;
        /* 0xF6 */ public bool UseSpeedBasedSpring;
        /* 0xF7 */ public bool UseCustomBlendTime;
        /* 0xF8 */ public float CustomBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xFC */ public byte[] EndPadding;
    }
}
