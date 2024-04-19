namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D4EF68A1BE622F5, NameHash = 0x93C5F18EADCD6C3C)]
    public class GcGroundWormComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 AttackDamageType;
        /* 0x010 */ public NMSString0x10 EmergeEffect;
        /* 0x020 */ public NMSString0x10 EmergeShake;
        /* 0x030 */ public NMSString0x10 RoarShake;
        /* 0x040 */ public NMSString0x10 SubmergeEffect;
        /* 0x050 */ public float AttackAngle;
        /* 0x054 */ public float AttackCooldown;
        /* 0x058 */ public float AttackDamageRadius;
        /* 0x05C */ public float AttackDistMax;
        /* 0x060 */ public float AttackDistMin;
        /* 0x064 */ public float CollisionBodySize;
        /* 0x068 */ public float EmergeDist;
        /* 0x06C */ public float EmergeEffectTime;
        /* 0x070 */ public float EmergeLookBlendEnd;
        /* 0x074 */ public float EmergeLookBlendStart;
        /* 0x078 */ public float EmergeTime;
        /* 0x07C */ public float FlinchAngleMax;
        /* 0x080 */ public float FlinchAngleMin;
        /* 0x084 */ public float FlinchSmooth;
        /* 0x088 */ public float FlinchTime;
        /* 0x08C */ public float LungeAngleBase;
        /* 0x090 */ public float LungeAngleHead;
        /* 0x094 */ public float LungeBeginTime;
        /* 0x098 */ public float LungeBlendInSpeed;
        /* 0x09C */ public float LungeBlendOutSpeed;
        /* 0x0A0 */ public float LungeEndTime;
        /* 0x0A4 */ public float LungeStrength;
        /* 0x0A8 */ public float RearUpBeginDist;
        /* 0x0AC */ public float RearUpEndDist;
        /* 0x0B0 */ public float RestTime;
        /* 0x0B4 */ public float RoarCooldown;
        /* 0x0B8 */ public float RumbleTime;
        /* 0x0BC */ public float SubmergeDepth;
        /* 0x0C0 */ public float SubmergeDist;
        /* 0x0C4 */ public float TrackTime;
        /* 0x0C8 */ public float TurnSpeed;
        /* 0x0CC */ public float WindUpAngleBase;
        /* 0x0D0 */ public float WindUpAngleHead;
        /* 0x0D4 */ public float WindUpStrength;
        /* 0x0D8 */ public NMSString0x100 GrabJoint;
        /* 0x1D8 */ public NMSString0x100 LookJoint;
    }
}
