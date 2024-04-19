using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F3DA013B89F0FCC, NameHash = 0x132EB7906E53B7A7)]
    public class GcCreatureData : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Data;
        /* 0x10 */ public NMSString0x10 Id;
        /* 0x20 */ public List<GcCreatureTagAndRarity> Tags;
        /* 0x30 */ public GcCreatureTypes ForceType;
        /* 0x34 */ public float FurChance;
        /* 0x38 */ public float FurLengthModifierAtMaxScale;
        /* 0x3C */ public float FurLengthModifierAtMinScale;
        /* 0x40 */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;
        /* 0x44 */ public float MaxScale;
        /* 0x48 */ public float MinScale;
        // size: 0x4
        public enum MoveAreaEnum : uint {
            Ground,
            Water,
            Air,
            Space,
        }
        /* 0x4C */ public MoveAreaEnum MoveArea;
        /* 0x50 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        /* 0x54 */ public GcCreatureRarity Rarity;
        /* 0x58 */ public GcCreatureTypes RealType;
        /* 0x5C */ public bool CanBeFemale;
        /* 0x5D */ public bool EcoSystemCreature;
        /* 0x5E */ public bool OnlySpawnWhenIdIsForced;
    }
}
