using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF035D90CAE5A88, NameHash = 0x37FF1400)]
    public class GcMessageProjectileImpact : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public Vector3f PosLocal;
        [NMS(Index = 9)]
        /* 0x10 */ public Vector3f PosOffset;
        [NMS(Index = 10)]
        /* 0x20 */ public List<GcImpactCombatEffectData> CombatEffects;
        [NMS(Index = 11)]
        /* 0x30 */ public List<GcCombatEffectDamageMultiplier> DamageMultipliers;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x50 */ public int Damage;
        // size: 0x3
        public enum HitTypeEnum : uint {
            Shootable,
            Terrain,
            Generic,
        }
        [NMS(Index = 7)]
        /* 0x54 */ public HitTypeEnum HitType;
        [NMS(Index = 6)]
        /* 0x58 */ public GcNodeID Node;
        [NMS(Index = 2)]
        /* 0x5C */ public GcDamageType Type;
        [NMS(Index = 3)]
        /* 0x60 */ public bool Critical;
        [NMS(Index = 4)]
        /* 0x61 */ public bool Ineffective;
        [NMS(Index = 5)]
        /* 0x62 */ public bool LaserHeatBoost;
    }
}
