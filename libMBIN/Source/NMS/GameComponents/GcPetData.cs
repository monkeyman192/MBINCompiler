using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x405D33E9FFED2299, NameHash = 0x65B2753E)]
    public class GcPetData : NMSTemplate
    {
        [NMS(Index = 33, Size = 0x5)]
        /* 0x000 */ public GcPetBattlerMoveInitData[] PetBattlerMoveList;
        [NMS(Index = 34, Size = 0x5)]
        /* 0x078 */ public NMSString0x10[] PetBattlerMoves;
        [NMS(Index = 7)]
        /* 0x0C8 */ public NMSString0x20A CustomSpeciesName;
        [NMS(Index = 12)]
        /* 0x0E8 */ public GcSeed BoneScaleSeed;
        [NMS(Index = 11)]
        /* 0x0F8 */ public GcSeed ColourBaseSeed;
        [NMS(Index = 1)]
        /* 0x108 */ public NMSString0x10 CreatureID;
        [NMS(Index = 4)]
        /* 0x118 */ public GcSeed CreatureSecondarySeed;
        [NMS(Index = 3)]
        /* 0x128 */ public GcSeed CreatureSeed;
        [NMS(Index = 2)]
        /* 0x138 */ public List<NMSString0x20A> Descriptors;
        [NMS(Index = 16)]
        /* 0x148 */ public ulong BirthTime;
        [NMS(Index = 6)]
        /* 0x150 */ public ulong GenusSeed;
        [NMS(Index = 17)]
        /* 0x158 */ public ulong LastEggTime;
        [NMS(Index = 19)]
        /* 0x160 */ public ulong LastTrustDecreaseTime;
        [NMS(Index = 18)]
        /* 0x168 */ public ulong LastTrustIncreaseTime;
        [NMS(Index = 5)]
        /* 0x170 */ public ulong SpeciesSeed;
        [NMS(Index = 9)]
        /* 0x178 */ public ulong UA;
        [NMS(Index = 24)]
        /* 0x180 */ public GcDiscoveryOwner SenderData;
        [NMS(Index = 28, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x284 */ public GcInventoryClass[] PetBattlerCoreStatClassOverrides;
        [NMS(Index = 29, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x290 */ public int[] PetBattlerTreatsEaten;
        [NMS(Index = 25, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x29C */ public float[] Traits;
        [NMS(Index = 26, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x2A8 */ public float[] Moods;
        [NMS(Index = 14)]
        /* 0x2B0 */ public GcBiomeType Biome;
        [NMS(Index = 15)]
        /* 0x2B4 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 31)]
        /* 0x2B8 */ public float PetBattleProgressToTreat;
        [NMS(Index = 30)]
        /* 0x2BC */ public int PetBattlerTreatsAvailable;
        [NMS(Index = 32)]
        /* 0x2C0 */ public int PetBattlerVictories;
        [NMS(Index = 0)]
        /* 0x2C4 */ public float Scale;
        [NMS(Index = 23)]
        /* 0x2C8 */ public float Trust;
        [NMS(Index = 22)]
        /* 0x2CC */ public NMSString0x20 CustomName;
        [NMS(Index = 10)]
        /* 0x2EC */ public bool AllowUnmodifiedReroll;
        [NMS(Index = 20)]
        /* 0x2ED */ public bool EggModified;
        [NMS(Index = 21)]
        /* 0x2EE */ public bool HasBeenSummoned;
        [NMS(Index = 13)]
        /* 0x2EF */ public bool HasFur;
        [NMS(Index = 27)]
        /* 0x2F0 */ public bool PetBattlerUseCoreStatClassOverrides;
        [NMS(Index = 8)]
        /* 0x2F1 */ public bool Predator;
    }
}
