using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91E9DBB754EF978A, NameHash = 0x65B2753E)]
    public class GcPetData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public NMSString0x20A CustomSpeciesName;
        [NMS(Index = 12)]
        /* 0x020 */ public GcSeed BoneScaleSeed;
        [NMS(Index = 11)]
        /* 0x030 */ public GcSeed ColourBaseSeed;
        [NMS(Index = 1)]
        /* 0x040 */ public NMSString0x10 CreatureID;
        [NMS(Index = 4)]
        /* 0x050 */ public GcSeed CreatureSecondarySeed;
        [NMS(Index = 3)]
        /* 0x060 */ public GcSeed CreatureSeed;
        [NMS(Index = 2)]
        /* 0x070 */ public List<NMSString0x20A> Descriptors;
        [NMS(Index = 16)]
        /* 0x080 */ public ulong BirthTime;
        [NMS(Index = 6)]
        /* 0x088 */ public ulong GenusSeed;
        [NMS(Index = 17)]
        /* 0x090 */ public ulong LastEggTime;
        [NMS(Index = 19)]
        /* 0x098 */ public ulong LastTrustDecreaseTime;
        [NMS(Index = 18)]
        /* 0x0A0 */ public ulong LastTrustIncreaseTime;
        [NMS(Index = 5)]
        /* 0x0A8 */ public ulong SpeciesSeed;
        [NMS(Index = 9)]
        /* 0x0B0 */ public ulong UA;
        [NMS(Index = 24)]
        /* 0x0B8 */ public GcDiscoveryOwner SenderData;
        [NMS(Index = 25, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x1BC */ public float[] Traits;
        [NMS(Index = 26, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x1C8 */ public float[] Moods;
        [NMS(Index = 14)]
        /* 0x1D0 */ public GcBiomeType Biome;
        [NMS(Index = 15)]
        /* 0x1D4 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 0)]
        /* 0x1D8 */ public float Scale;
        [NMS(Index = 23)]
        /* 0x1DC */ public float Trust;
        [NMS(Index = 22)]
        /* 0x1E0 */ public NMSString0x20 CustomName;
        [NMS(Index = 10)]
        /* 0x200 */ public bool AllowUnmodifiedReroll;
        [NMS(Index = 20)]
        /* 0x201 */ public bool EggModified;
        [NMS(Index = 21)]
        /* 0x202 */ public bool HasBeenSummoned;
        [NMS(Index = 13)]
        /* 0x203 */ public bool HasFur;
        [NMS(Index = 8)]
        /* 0x204 */ public bool Predator;
    }
}
