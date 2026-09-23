using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x122DCC046BC836B2, NameHash = 0xA09640A7)]
    public class GcGameTablePetData : NMSTemplate
    {
        [NMS(Index = 15, Size = 0x5)]
        /* 0x000 */ public GcPetBattlerMoveInitData[] MoveInitDataList;
        [NMS(Index = 16, Size = 0x5)]
        /* 0x078 */ public NMSString0x10[] MovesList;
        [NMS(Index = 5)]
        /* 0x0C8 */ public GcSeed BoneScaleSeed;
        [NMS(Index = 4)]
        /* 0x0D8 */ public GcSeed ColourBaseSeed;
        [NMS(Index = 8)]
        /* 0x0E8 */ public List<NMSString0x20A> Descriptors;
        [NMS(Index = 10)]
        /* 0x0F8 */ public GcSeed DescriptorSecondarySeed;
        [NMS(Index = 9)]
        /* 0x108 */ public GcSeed DescriptorSeed;
        [NMS(Index = 0)]
        /* 0x118 */ public NMSString0x10 ID;
        [NMS(Index = 12)]
        /* 0x128 */ public GcSeed PetBattlerSeed;
        [NMS(Index = 1)]
        /* 0x138 */ public GcSeed Seed;
        [NMS(Index = 19, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x148 */ public GcInventoryClass[] CoreStatClassOverrides;
        [NMS(Index = 13, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x154 */ public int[] StatTreatsEaten;
        [NMS(Index = 17, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x160 */ public float[] Traits;
        [NMS(Index = 6)]
        /* 0x16C */ public float Babify;
        [NMS(Index = 3)]
        /* 0x170 */ public GcBiomeType Biome;
        [NMS(Index = 7)]
        /* 0x174 */ public float Scale;
        [NMS(Index = 14)]
        /* 0x178 */ public int ThumbnailIndex;
        [NMS(Index = 11)]
        /* 0x17C */ public NMSString0x20 Name;
        [NMS(Index = 2)]
        /* 0x19C */ public GcPetBattlerAffinity Affinity;
        [NMS(Index = 18)]
        /* 0x19D */ public bool UseCoreStatClassOverrides;
    }
}
