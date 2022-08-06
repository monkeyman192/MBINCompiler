using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59D8399F15DC13FF, NameHash = 0x995CD6C5BC075C98)]
    public class GcPetData : NMSTemplate
    {
        /* 0x000 */ public float Scale;
        /* 0x008 */ public NMSString0x10 CreatureID;
        /* 0x018 */ public List<NMSString0x20A> Descriptors;
        /* 0x028 */ public GcSeed CreatureSeed;
        /* 0x038 */ public GcSeed CreatureSecondarySeed;
        /* 0x048 */ public ulong SpeciesSeed;
        /* 0x050 */ public ulong GenusSeed;
        /* 0x058 */ public NMSString0x20A CustomSpeciesName;
        /* 0x078 */ public bool Predator;
        /* 0x080 */ public ulong UA;
        /* 0x088 */ public bool AllowUnmodifiedReroll;
        /* 0x090 */ public GcSeed ColourBaseSeed;
        /* 0x0A0 */ public GcSeed BoneScaleSeed;
        /* 0x0B0 */ public bool HasFur;
        /* 0x0B4 */ public GcBiomeType Biome;
        /* 0x0B8 */ public GcCreatureTypes CreatureType;
        /* 0x0C0 */ public ulong BirthTime;
        /* 0x0C8 */ public ulong LastEggTime;
        /* 0x0D0 */ public ulong LastTrustIncreaseTime;
        /* 0x0D8 */ public ulong LastTrustDecreaseTime;
        /* 0x0E0 */ public bool EggModified;
        /* 0x0E1 */ public bool HasBeenSummoned;
        /* 0x0E2 */ public NMSString0x20 CustomName;
        /* 0x104 */ public float Trust;
        /* 0x108 */ public GcDiscoveryOwner SenderData;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        /* 0x20C */ public float[] Traits;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x218 */ public float[] Moods;
    }
}