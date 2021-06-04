using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE8, GUID = 0x254F5939772BE7DC, NameHash = 0x41B161469E53B05E)]
    public class GcCreatureFiendAttackData : NMSTemplate
    {
        /* 0x00 */ public float NearDist;
        /* 0x04 */ public float FarDist;
        /* 0x08 */ public float ModifyDistanceForHeight;
        /* 0x10 */ public NMSString0x10 SpitAnim;
        /* 0x20 */ public int SpitAnimFrame;
        /* 0x24 */ public NMSString0x40 SpitJoint;
        /* 0x68 */ public NMSString0x10 SpitProjectile;
        /* 0x78 */ public bool AllowSpit;
        /* 0x7C */ public float DelayBetweenSpitAttacks;
        /* 0x80 */ public bool AllowPounce;
        /* 0x84 */ public float DelayBetweenPounceAttacks;
        /* 0x88 */ public NMSString0x40 AttackLight;
        /* 0xC8 */ public float IdleLightIntensity;
        /* 0xCC */ public float AttackLightIntensity;
        /* 0xD0 */ public int MinFlurryHits;
        /* 0xD4 */ public int MaxFlurryHits;
        /* 0xD8 */ public float RoarChanceOnHit;
        /* 0xDC */ public float RoarChanceOnMiss;
        /* 0xE0 */ public float StartDamageTime;
        /* 0xE4 */ public float TurnToFaceTime;
    }
}