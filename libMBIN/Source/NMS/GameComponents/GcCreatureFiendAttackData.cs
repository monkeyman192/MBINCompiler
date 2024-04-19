namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4A53608778A385B, NameHash = 0x41B161469E53B05E)]
    public class GcCreatureFiendAttackData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SpitAnim;
        /* 0x10 */ public NMSString0x10 SpitProjectile;
        /* 0x20 */ public float AttackLightIntensity;
        /* 0x24 */ public float DelayBetweenPounceAttacks;
        /* 0x28 */ public float DelayBetweenSpitAttacks;
        /* 0x2C */ public float FarDist;
        /* 0x30 */ public float IdleLightIntensity;
        /* 0x34 */ public int MaxFlurryHits;
        /* 0x38 */ public int MinFlurryHits;
        /* 0x3C */ public float ModifyDistanceForHeight;
        /* 0x40 */ public float NearDist;
        /* 0x44 */ public float RoarChanceOnHit;
        /* 0x48 */ public float RoarChanceOnMiss;
        /* 0x4C */ public int SpitAnimFrame;
        /* 0x50 */ public float StartDamageTime;
        /* 0x54 */ public float TurnToFaceTime;
        /* 0x58 */ public NMSString0x40 AttackLight;
        /* 0x98 */ public NMSString0x40 SpitJoint;
        /* 0xD8 */ public bool AllowPounce;
        /* 0xD9 */ public bool AllowSpit;
    }
}
