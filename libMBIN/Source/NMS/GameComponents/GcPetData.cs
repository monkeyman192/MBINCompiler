using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F0, GUID = 0x2BC31D4B0F326B49, NameHash = 0x995CD6C5BC075C98)]
    public class GcPetData : NMSTemplate
    {
        /* 0x000 */ public float Scale;
        /* 0x008 */ public NMSString0x10 CreatureID;
        /* 0x018 */ public List<NMSString0x20A> Descriptors;
        /* 0x028 */ public GcSeed CreatureSeed;
        /* 0x038 */ public GcSeed CreatureSecondarySeed;
        /* 0x048 */ public ulong SpeciesSeed;
        /* 0x050 */ public ulong GenusSeed;
        /* 0x058 */ public bool Predator;
        /* 0x060 */ public ulong UA;
        /* 0x068 */ public GcSeed ColourBaseSeed;
        /* 0x078 */ public GcSeed BoneScaleSeed;
        /* 0x088 */ public GcBiomeType Biome;
        /* 0x08C */ public GcCreatureTypes CreatureType;
        /* 0x090 */ public ulong BirthTime;
        /* 0x098 */ public ulong LastEggTime;
        /* 0x0A0 */ public ulong LastTrustIncreaseTime;
        /* 0x0A8 */ public ulong LastTrustDecreaseTime;
        /* 0x0B0 */ public bool EggModified;
        /* 0x0B1 */ public bool HasBeenSummoned;
        /* 0x0B2 */ public NMSString0x20 CustomName;
        /* 0x0D4 */ public float Trust;
        /* 0x0D8 */ public GcDiscoveryOwner SenderData;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        /* 0x1DC */ public float[] Traits;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x1E8 */ public float[] Moods;
    }
}