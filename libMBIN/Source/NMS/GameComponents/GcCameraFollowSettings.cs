using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8F2ED45BE165955, NameHash = 0x200FDA306DC86654)]
    public class GcCameraFollowSettings : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float MinSpeed;
        /* 0x14 */ public float SpeedRange;
        /* 0x18 */ public float OffsetX;
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
        /* 0x50 */ public float OffsetYExtraMaxDistance;
        /* 0x54 */ public float PanNear;
        /* 0x58 */ public float PanFar;
        /* 0x5C */ public float UpGamma;
        /* 0x60 */ public float HorizRotationAngleMaxPerFrame;
        /* 0x64 */ public float VertRotationSpeed;
        /* 0x68 */ public float VertRotationMin;
        /* 0x6C */ public float VertRotationMax;
        /* 0x70 */ public float VertRotationOffset;
        /* 0x74 */ public float VertRotationOffsetMinAngle;
        /* 0x78 */ public float VertRotationOffsetMaxAngle;
        /* 0x7C */ public bool VertStartLookingDown;
        /* 0x80 */ public float DistSpeed;
        /* 0x84 */ public float DistSpeedOutsideMainRange;
        /* 0x88 */ public float DistStiffness;
        /* 0x8C */ public float SpringSpeed;
        /* 0x90 */ public bool LockToObjectOnIdle;
        /* 0x94 */ public float CenterStartTime;
        /* 0x98 */ public float CenterBlendTime;
        /* 0x9C */ public float CenterMaxSpring;
        /* 0xA0 */ public float CenterMaxSpeed;
        /* 0xA4 */ public float VelocityAnticipate;
        /* 0xA8 */ public float VelocityAnticipateSpringSpeed;
        /* 0xAC */ public float VertMaxSpring;
        /* 0xB0 */ public float CenterStartSpeed;
        /* 0xB4 */ public float MinClose;
        /* 0xB8 */ public float MaxClose;
        /* 0xBC */ public float CloseSpring;
        /* 0xC0 */ public float LookStickLimitAngle;
        /* 0xC4 */ public bool EnableCollisionDetection;
        /* 0xC8 */ public int NumLRProbes;
        /* 0xCC */ public float LRProbesRange;
        /* 0xD0 */ public float LRProbesRadius;
        /* 0xD4 */ public int NumUDProbes;
        /* 0xD8 */ public float UDProbesRange;
        /* 0xDC */ public float ProbeCenterX;
        /* 0xE0 */ public float ProbeCenterY;
        /* 0xE4 */ public float PushForwardDropoffLR;
        /* 0xE8 */ public float PushForwardDropoffUD;
        /* 0xEC */ public float AvoidCollisionLRSpeed;
        /* 0xF0 */ public float AvoidCollisionUDSpeed;
        /* 0xF4 */ public float AvoidCollisionPushSpeed;
        /* 0xF8 */ public bool AvoidCollisionUDUseStickDelay;
        /* 0xF9 */ public bool AvoidCollisionLRUseStickDelay;
        /* 0xFA */ public bool UseSpeedBasedSpring;
        /* 0xFB */ public bool UseCustomBlendTime;
        /* 0xFC */ public float CustomBlendTime;
    }
}
