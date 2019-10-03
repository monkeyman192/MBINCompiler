using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x62F399B99B149834, NameHash = 0x2AA340CCDBA01EAD)]
    public class GcThirdPersonAnimParams : NMSTemplate
    {
		/* 0x00 */ public Vector2f Velocity;
        /* 0x08 */ public Vector2f VelocityXY;
        /* 0x10 */ public float VelocityY;
        /* 0x14 */ public float VelocityZ;
        /* 0x18 */ public Vector2f MoveForce;
        /* 0x20 */ public float MoveForceApplied;
        /* 0x24 */ public Vector2f AimDirection;
        /* 0x2C */ public float Speed;
        /* 0x30 */ public float Foot;
        /* 0x34 */ public float HitLR;
        /* 0x38 */ public float HitFB;
        /* 0x3C */ public float LeanLR;
        /* 0x40 */ public float LeanFB;
        /* 0x44 */ public float AimPitch;
        /* 0x48 */ public float AimYaw;
        /* 0x4C */ public float TurnAngle;
        /* 0x50 */ public float DistanceFromGround;
        /* 0x54 */ public float Uphill;
        /* 0x58 */ public float SlopeAngle;
        /* 0x5C */ public float TimeSinceJetpackEngaged;
    }
}
