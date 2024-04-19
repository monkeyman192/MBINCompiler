using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF66E462C127861F, NameHash = 0x7EBC25FE326CF24B)]
    public class GcMessageProjectileImpact : NMSTemplate
    {
        /* 0x00 */ public Vector3f PosLocal;
        /* 0x10 */ public Vector3f PosOffset;
        /* 0x20 */ public List<GcImpactCombatEffectData> CombatEffects;
        /* 0x30 */ public List<GcCombatEffectDamageMultiplier> DamageMultipliers;
        /* 0x40 */ public NMSString0x10 Id;
        /* 0x50 */ public int Damage;
        // size: 0x3
        public enum HitTypeEnum : uint {
            Shootable,
            Terrain,
            Generic,
        }
        /* 0x54 */ public HitTypeEnum HitType;
        /* 0x58 */ public GcNodeID Node;
        /* 0x5C */ public GcDamageType Type;
        /* 0x60 */ public bool Critical;
        /* 0x61 */ public bool Ineffective;
        /* 0x62 */ public bool LaserHeatBoost;
    }
}
