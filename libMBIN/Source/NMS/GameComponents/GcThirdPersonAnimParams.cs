namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BA36A3444947135, NameHash = 0x2AA340CCDBA01EAD)]
    public class GcThirdPersonAnimParams : NMSTemplate
    {
        /* 0x00 */ public Vector2f AimDirection;
        /* 0x08 */ public Vector2f MoveForce;
        /* 0x10 */ public Vector2f Velocity;
        /* 0x18 */ public Vector2f VelocityXY;
        /* 0x20 */ public float AimPitch;
        /* 0x24 */ public float AimYaw;
        /* 0x28 */ public float DistanceFromGround;
        /* 0x2C */ public float Foot;
        /* 0x30 */ public float HitFB;
        /* 0x34 */ public float HitLR;
        /* 0x38 */ public float LeanFB;
        /* 0x3C */ public float LeanLR;
        /* 0x40 */ public float MoveForceApplied;
        /* 0x44 */ public float SlopeAngle;
        /* 0x48 */ public float Speed;
        /* 0x4C */ public float TimeSinceJetpackEngaged;
        /* 0x50 */ public float TurnAngle;
        /* 0x54 */ public float Uphill;
        /* 0x58 */ public float VelocityY;
        /* 0x5C */ public float VelocityZ;
    }
}
