namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C710345FA93390, NameHash = 0x41B161469E53B05E)]
    public class GcCreatureFiendAttackData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 SpitAnim;
        [NMS(Index = 6)]
        /* 0x10 */ public NMSString0x10 SpitProjectile;
        [NMS(Index = 13)]
        /* 0x20 */ public float AttackLightIntensity;
        [NMS(Index = 10)]
        /* 0x24 */ public float DelayBetweenPounceAttacks;
        [NMS(Index = 8)]
        /* 0x28 */ public float DelayBetweenSpitAttacks;
        [NMS(Index = 1)]
        /* 0x2C */ public float FarDist;
        [NMS(Index = 12)]
        /* 0x30 */ public float IdleLightIntensity;
        [NMS(Index = 15)]
        /* 0x34 */ public int MaxFlurryHits;
        [NMS(Index = 14)]
        /* 0x38 */ public int MinFlurryHits;
        [NMS(Index = 2)]
        /* 0x3C */ public float ModifyDistanceForHeight;
        [NMS(Index = 0)]
        /* 0x40 */ public float NearDist;
        [NMS(Index = 16)]
        /* 0x44 */ public float RoarChanceOnHit;
        [NMS(Index = 17)]
        /* 0x48 */ public float RoarChanceOnMiss;
        [NMS(Index = 4)]
        /* 0x4C */ public int SpitAnimFrame;
        [NMS(Index = 18)]
        /* 0x50 */ public float StartDamageTime;
        [NMS(Index = 19)]
        /* 0x54 */ public float TurnToFaceTime;
        [NMS(Index = 11)]
        /* 0x58 */ public NMSString0x40 AttackLight;
        [NMS(Index = 5)]
        /* 0x98 */ public NMSString0x40 SpitJoint;
        [NMS(Index = 9)]
        /* 0xD8 */ public bool AllowPounce;
        [NMS(Index = 7)]
        /* 0xD9 */ public bool AllowSpit;
    }
}
