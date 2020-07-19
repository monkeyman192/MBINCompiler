using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x9B489B7B8EFB8432, NameHash = 0x132EB7906E53B7A7)]
    public class GcCreatureData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public bool OnlySpawnWhenIdIsForced;

        [NMS(Size = 0x20)]
        /* 0x11 */ public string Genus;

        [NMS(Size = 0x3, Ignore = true)]
        /* 0x31 */ public byte[] Padding31;

        /* 0x34 */ public GcCreatureTypes ForceType;
		public enum MoveAreaEnum { Ground, Water, Air, Space }
		public MoveAreaEnum MoveArea;

        /* 0x3C */ public float MinScale;
        /* 0x40 */ public float MaxScale;
        /* 0x44 */ public GcRarity Rarity;
        /* 0x48 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        /* 0x4C */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;

        /* 0x50 */ public List<NMSTemplate> Data;
    }
}
