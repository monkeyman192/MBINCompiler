using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xC271DD5B240D368B, NameHash = 0x132EB7906E53B7A7)]
    public class GcCreatureData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool OnlySpawnWhenIdIsForced;
        /* 0x14 */ public GcCreatureTypes ForceType;
        /* 0x18 */ public GcCreatureTypes RealType;
        /* 0x1C */ public bool EcoSystemCreature;
        /* 0x1D */ public bool CanBeFemale;
        /* 0x20 */ public List<GcCreatureTagAndRarity> Tags;
        public enum MoveAreaEnum { Ground, Water, Air, Space }
		/* 0x30 */ public MoveAreaEnum MoveArea;
        /* 0x34 */ public float MinScale;
        /* 0x38 */ public float MaxScale;
        /* 0x3C */ public GcCreatureRarity Rarity;
        /* 0x40 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        /* 0x44 */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;
        /* 0x48 */ public List<NMSTemplate> Data;
    }
}
