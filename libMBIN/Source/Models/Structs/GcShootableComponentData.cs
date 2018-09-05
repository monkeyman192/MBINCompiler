namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x78, Alignment = 0x8)]
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ public int Health;
		/* 0x04 */ public bool AutoAimTarget;
		/* 0x05 */ public bool PlayerOnly;
		/* 0x06 */ public bool ImpactShake;
		[NMS(Size = 1, Ignore = true)]
		/* 0x07 */ public byte[] Padding7;
		[NMS(Size = 0x10)]
		/* 0x08 */ public string ImpactShakeEffect;

		/* 0x18 */ public GcProjectileImpactType ForceImpactType;
		/* 0x1C */ public int IncreaseWanted;
		/* 0x20 */ public float IncreaseWantedThresholdTime;
        /* 0x24 */ public bool IncreaseFiendWanted;
		/* 0x28 */ public float RepairTime;
		/* 0x2C */ public int MinDamage;
		/* 0x30 */ public bool StaticUntilShot;
        /* 0x31 */ public bool HitEffectEnabled;
        /* 0x32 */ public bool HitEffectEntireModel;
        [NMS(Size = 0x20)]
        /* 0x33 */ public string NameOverride;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x53 */ public byte[] Padding53;

		[NMS(Size = 0x10)]
		/* 0x58 */	public string RequiredTech;
        [NMS(Size = 0x10)]
		/* 0x68 */	public string DamageMultiplier;

    }
}
