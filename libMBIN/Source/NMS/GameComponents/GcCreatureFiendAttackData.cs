namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F238F3B1F243FE7, NameHash = 0x942A27D2)]
    public class GcCreatureFiendAttackData : NMSTemplate
    {
        [NMS(Index = 19)]
        /* 0x000 */ public NMSString0x10 PushBackAttackAnim;
        [NMS(Index = 20)]
        /* 0x010 */ public NMSString0x10 PushBackDamageID;
        [NMS(Index = 17)]
        /* 0x020 */ public NMSString0x10 SpawnBroodAnim;
        [NMS(Index = 15)]
        /* 0x030 */ public NMSString0x10 SpawnBroodID;
        [NMS(Index = 3)]
        /* 0x040 */ public NMSString0x10 SpitAnim;
        [NMS(Index = 6)]
        /* 0x050 */ public NMSString0x10 SpitProjectile;
        [NMS(Index = 33)]
        /* 0x060 */ public NMSString0x10 TurnLAnim;
        [NMS(Index = 34)]
        /* 0x070 */ public NMSString0x10 TurnRAnim;
        [NMS(Index = 37)]
        /* 0x080 */ public Vector2f TurnAnimSpeeds;
        [NMS(Index = 32)]
        /* 0x088 */ public float AnimSpeedModifier;
        [NMS(Index = 25)]
        /* 0x08C */ public float AttackLightIntensity;
        [NMS(Index = 13)]
        /* 0x090 */ public float DelayBetweenPounceAttacks;
        [NMS(Index = 11)]
        /* 0x094 */ public float DelayBetweenSpitAttacks;
        [NMS(Index = 1)]
        /* 0x098 */ public float FarDist;
        [NMS(Index = 24)]
        /* 0x09C */ public float IdleLightIntensity;
        [NMS(Index = 27)]
        /* 0x0A0 */ public int MaxFlurryHits;
        [NMS(Index = 26)]
        /* 0x0A4 */ public int MinFlurryHits;
        [NMS(Index = 2)]
        /* 0x0A8 */ public float ModifyDistanceForHeight;
        [NMS(Index = 0)]
        /* 0x0AC */ public float NearDist;
        [NMS(Index = 22)]
        /* 0x0B0 */ public int PushBackAttackFrame;
        [NMS(Index = 21)]
        /* 0x0B4 */ public float PushBackRange;
        [NMS(Index = 28)]
        /* 0x0B8 */ public float RoarChanceOnHit;
        [NMS(Index = 29)]
        /* 0x0BC */ public float RoarChanceOnMiss;
        [NMS(Index = 16)]
        /* 0x0C0 */ public float SpawnBroodTimer;
        [NMS(Index = 4)]
        /* 0x0C4 */ public int SpitAnimFrame;
        [NMS(Index = 10)]
        /* 0x0C8 */ public float SpitFacingRequirement;
        [NMS(Index = 30)]
        /* 0x0CC */ public float StartDamageTime;
        [NMS(Index = 36)]
        /* 0x0D0 */ public float TurnAnimAngleMax;
        [NMS(Index = 35)]
        /* 0x0D4 */ public float TurnAnimAngleMin;
        [NMS(Index = 31)]
        /* 0x0D8 */ public float TurnToFaceTime;
        [NMS(Index = 23)]
        /* 0x0DC */ public NMSString0x40 AttackLight;
        [NMS(Index = 5)]
        /* 0x11C */ public NMSString0x40 SpitJoint;
        [NMS(Index = 12)]
        /* 0x15C */ public bool AllowPounce;
        [NMS(Index = 18)]
        /* 0x15D */ public bool AllowPushBackAttack;
        [NMS(Index = 14)]
        /* 0x15E */ public bool AllowSpawnBrood;
        [NMS(Index = 7)]
        /* 0x15F */ public bool AllowSpit;
        [NMS(Index = 9)]
        /* 0x160 */ public bool AllowSpitAlways;
        [NMS(Index = 8)]
        /* 0x161 */ public bool AOESpitAttack;
    }
}
