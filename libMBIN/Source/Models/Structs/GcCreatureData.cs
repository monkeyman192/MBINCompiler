using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x60)]
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
        /* 0x38 */ public int MoveArea;
        public string[] MoveAreaValues()
        {
            return new[] { "Ground", "Water", "Air", "Space" };
        }

        /* 0x3C */ public float MinScale;
        /* 0x40 */ public float MaxScale;
        /* 0x44 */ public GcRarity Rarity;
        /* 0x48 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        /* 0x4C */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;

        /* 0x50 */ public List<NMSTemplate> Data;
    }
}
