using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E297E9658CBEFAB, NameHash = 0x995CD6C5BC075C98)]
    public class GcPetData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CustomSpeciesName;
        /* 0x020 */ public GcSeed BoneScaleSeed;
        /* 0x030 */ public GcSeed ColourBaseSeed;
        /* 0x040 */ public NMSString0x10 CreatureID;
        /* 0x050 */ public GcSeed CreatureSecondarySeed;
        /* 0x060 */ public GcSeed CreatureSeed;
        /* 0x070 */ public List<NMSString0x20A> Descriptors;
        /* 0x080 */ public ulong BirthTime;
        /* 0x088 */ public ulong GenusSeed;
        /* 0x090 */ public ulong LastEggTime;
        /* 0x098 */ public ulong LastTrustDecreaseTime;
        /* 0x0A0 */ public ulong LastTrustIncreaseTime;
        /* 0x0A8 */ public ulong SpeciesSeed;
        /* 0x0B0 */ public ulong UA;
        /* 0x0B8 */ public GcDiscoveryOwner SenderData;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x1BC */ public float[] Traits;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x1C8 */ public float[] Moods;
        /* 0x1D0 */ public GcBiomeType Biome;
        /* 0x1D4 */ public GcCreatureTypes CreatureType;
        /* 0x1D8 */ public float Scale;
        /* 0x1DC */ public float Trust;
        /* 0x1E0 */ public NMSString0x20 CustomName;
        /* 0x200 */ public bool AllowUnmodifiedReroll;
        /* 0x201 */ public bool EggModified;
        /* 0x202 */ public bool HasBeenSummoned;
        /* 0x203 */ public bool HasFur;
        /* 0x204 */ public bool Predator;
    }
}
