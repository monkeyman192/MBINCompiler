using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F3DA013B89F0FCC, NameHash = 0x132EB7906E53B7A7)]
    public class GcCreatureData : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public List<NMSTemplate> Data;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x20 */ public List<GcCreatureTagAndRarity> Tags;
        [NMS(Index = 2)]
        /* 0x30 */ public GcCreatureTypes ForceType;
        [NMS(Index = 12)]
        /* 0x34 */ public float FurChance;
        [NMS(Index = 11)]
        /* 0x38 */ public float FurLengthModifierAtMaxScale;
        [NMS(Index = 10)]
        /* 0x3C */ public float FurLengthModifierAtMinScale;
        [NMS(Index = 15)]
        /* 0x40 */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;
        [NMS(Index = 9)]
        /* 0x44 */ public float MaxScale;
        [NMS(Index = 8)]
        /* 0x48 */ public float MinScale;
        // size: 0x4
        public enum MoveAreaEnum : uint {
            Ground,
            Water,
            Air,
            Space,
        }
        [NMS(Index = 7)]
        /* 0x4C */ public MoveAreaEnum MoveArea;
        [NMS(Index = 14)]
        /* 0x50 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        [NMS(Index = 13)]
        /* 0x54 */ public GcCreatureRarity Rarity;
        [NMS(Index = 3)]
        /* 0x58 */ public GcCreatureTypes RealType;
        [NMS(Index = 5)]
        /* 0x5C */ public bool CanBeFemale;
        [NMS(Index = 4)]
        /* 0x5D */ public bool EcoSystemCreature;
        [NMS(Index = 1)]
        /* 0x5E */ public bool OnlySpawnWhenIdIsForced;
    }
}
