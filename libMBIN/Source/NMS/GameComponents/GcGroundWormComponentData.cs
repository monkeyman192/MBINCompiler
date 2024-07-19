namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFBC7C308C4BAA4A9, NameHash = 0xA8ED0FE1)]
    public class GcGroundWormComponentData : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x000 */ public NMSString0x10 AttackDamageType;
        [NMS(Index = 2)]
        /* 0x010 */ public NMSString0x10 EmergeEffect;
        [NMS(Index = 4)]
        /* 0x020 */ public NMSString0x10 EmergeShake;
        [NMS(Index = 5)]
        /* 0x030 */ public NMSString0x10 RoarShake;
        [NMS(Index = 41)]
        /* 0x040 */ public NMSString0x10 SpitProjectile;
        [NMS(Index = 3)]
        /* 0x050 */ public NMSString0x10 SubmergeEffect;
        [NMS(Index = 18)]
        /* 0x060 */ public float AttackAngle;
        [NMS(Index = 21)]
        /* 0x064 */ public float AttackCooldown;
        [NMS(Index = 17)]
        /* 0x068 */ public float AttackDamageRadius;
        [NMS(Index = 20)]
        /* 0x06C */ public float AttackDistMax;
        [NMS(Index = 19)]
        /* 0x070 */ public float AttackDistMin;
        [NMS(Index = 6)]
        /* 0x074 */ public float CollisionBodySize;
        [NMS(Index = 9)]
        /* 0x078 */ public float EmergeDist;
        [NMS(Index = 8)]
        /* 0x07C */ public float EmergeEffectTime;
        [NMS(Index = 37)]
        /* 0x080 */ public float EmergeLookBlendEnd;
        [NMS(Index = 36)]
        /* 0x084 */ public float EmergeLookBlendStart;
        [NMS(Index = 38)]
        /* 0x088 */ public float EmergeTime;
        [NMS(Index = 14)]
        /* 0x08C */ public float FlinchAngleMax;
        [NMS(Index = 13)]
        /* 0x090 */ public float FlinchAngleMin;
        [NMS(Index = 15)]
        /* 0x094 */ public float FlinchSmooth;
        [NMS(Index = 12)]
        /* 0x098 */ public float FlinchTime;
        [NMS(Index = 25)]
        /* 0x09C */ public float LungeAngleBase;
        [NMS(Index = 24)]
        /* 0x0A0 */ public float LungeAngleHead;
        [NMS(Index = 26)]
        /* 0x0A4 */ public float LungeBeginTime;
        [NMS(Index = 28)]
        /* 0x0A8 */ public float LungeBlendInSpeed;
        [NMS(Index = 29)]
        /* 0x0AC */ public float LungeBlendOutSpeed;
        [NMS(Index = 27)]
        /* 0x0B0 */ public float LungeEndTime;
        [NMS(Index = 23)]
        /* 0x0B4 */ public float LungeStrength;
        [NMS(Index = 39)]
        /* 0x0B8 */ public float RearUpBeginDist;
        [NMS(Index = 40)]
        /* 0x0BC */ public float RearUpEndDist;
        [NMS(Index = 33)]
        /* 0x0C0 */ public float RestTime;
        [NMS(Index = 22)]
        /* 0x0C4 */ public float RoarCooldown;
        [NMS(Index = 7)]
        /* 0x0C8 */ public float RumbleTime;
        [NMS(Index = 42)]
        /* 0x0CC */ public float SpitCooldown;
        [NMS(Index = 43)]
        /* 0x0D0 */ public int SpitCount;
        [NMS(Index = 11)]
        /* 0x0D4 */ public float SubmergeDepth;
        [NMS(Index = 10)]
        /* 0x0D8 */ public float SubmergeDist;
        [NMS(Index = 34)]
        /* 0x0DC */ public float TrackTime;
        [NMS(Index = 35)]
        /* 0x0E0 */ public float TurnSpeed;
        [NMS(Index = 32)]
        /* 0x0E4 */ public float WindUpAngleBase;
        [NMS(Index = 31)]
        /* 0x0E8 */ public float WindUpAngleHead;
        [NMS(Index = 30)]
        /* 0x0EC */ public float WindUpStrength;
        [NMS(Index = 1)]
        /* 0x0F0 */ public NMSString0x100 GrabJoint;
        [NMS(Index = 0)]
        /* 0x1F0 */ public NMSString0x100 LookJoint;
    }
}
