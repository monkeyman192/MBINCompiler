using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F8, GUID = 0xB63A18B6EB667948, NameHash = 0x995CD6C5BC075C98)]
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
        /* 0x088 */ public bool HasFur;
        /* 0x08C */ public GcBiomeType Biome;
        /* 0x090 */ public GcCreatureTypes CreatureType;
        /* 0x098 */ public ulong BirthTime;
        /* 0x0A0 */ public ulong LastEggTime;
        /* 0x0A8 */ public ulong LastTrustIncreaseTime;
        /* 0x0B0 */ public ulong LastTrustDecreaseTime;
        /* 0x0B8 */ public bool EggModified;
        /* 0x0B9 */ public bool HasBeenSummoned;
        /* 0x0BA */ public NMSString0x20 CustomName;
        /* 0x0DC */ public float Trust;
        /* 0x0E0 */ public GcDiscoveryOwner SenderData;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        /* 0x1E4 */ public float[] Traits;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x1F0 */ public float[] Moods;
    }
}