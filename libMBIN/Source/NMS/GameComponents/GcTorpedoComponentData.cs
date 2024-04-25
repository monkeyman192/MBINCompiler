namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA80E51B7009021F3, NameHash = 0xA5B9F71571A61869)]
    public class GcTorpedoComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DamageProjectileId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DamageShieldProjectileId;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 DestroyedEffect;
        [NMS(Index = 5)]
        /* 0x30 */ public float ApproachTime;
        [NMS(Index = 13)]
        /* 0x34 */ public float BrakeForceMax;
        [NMS(Index = 12)]
        /* 0x38 */ public float BrakeForceMin;
        [NMS(Index = 11)]
        /* 0x3C */ public float BrakeTime;
        [NMS(Index = 10)]
        /* 0x40 */ public float ForceMax;
        [NMS(Index = 9)]
        /* 0x44 */ public float ForceMin;
        [NMS(Index = 14)]
        /* 0x48 */ public float HitRadius;
        [NMS(Index = 4)]
        /* 0x4C */ public float MaxLifetime;
        [NMS(Index = 8)]
        /* 0x50 */ public float MaxSpeed;
        [NMS(Index = 6)]
        /* 0x54 */ public float MinCircleTime;
        [NMS(Index = 3)]
        /* 0x58 */ public float NoTargetLife;
        [NMS(Index = 7)]
        /* 0x5C */ public float RotateSpeed;
    }
}
