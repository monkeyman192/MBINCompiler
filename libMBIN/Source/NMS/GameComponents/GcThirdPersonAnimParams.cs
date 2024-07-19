namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DED3B31DC66E184, NameHash = 0xF4D42667)]
    public class GcThirdPersonAnimParams : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public Vector2f AimDirection;
        [NMS(Index = 4)]
        /* 0x08 */ public Vector2f MoveForce;
        [NMS(Index = 0)]
        /* 0x10 */ public Vector2f Velocity;
        [NMS(Index = 1)]
        /* 0x18 */ public Vector2f VelocityXY;
        [NMS(Index = 13)]
        /* 0x20 */ public float AimPitch;
        [NMS(Index = 14)]
        /* 0x24 */ public float AimYaw;
        [NMS(Index = 16)]
        /* 0x28 */ public float DistanceFromGround;
        [NMS(Index = 8)]
        /* 0x2C */ public float Foot;
        [NMS(Index = 10)]
        /* 0x30 */ public float HitFB;
        [NMS(Index = 9)]
        /* 0x34 */ public float HitLR;
        [NMS(Index = 12)]
        /* 0x38 */ public float LeanFB;
        [NMS(Index = 11)]
        /* 0x3C */ public float LeanLR;
        [NMS(Index = 5)]
        /* 0x40 */ public float MoveForceApplied;
        [NMS(Index = 18)]
        /* 0x44 */ public float SlopeAngle;
        [NMS(Index = 7)]
        /* 0x48 */ public float Speed;
        [NMS(Index = 19)]
        /* 0x4C */ public float TimeSinceJetpackEngaged;
        [NMS(Index = 15)]
        /* 0x50 */ public float TurnAngle;
        [NMS(Index = 17)]
        /* 0x54 */ public float Uphill;
        [NMS(Index = 2)]
        /* 0x58 */ public float VelocityY;
        [NMS(Index = 3)]
        /* 0x5C */ public float VelocityZ;
    }
}
