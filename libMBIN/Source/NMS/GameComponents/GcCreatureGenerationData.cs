using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB997A39B7E5F90C3, NameHash = 0x4742E3FE43A533C7)]
    public class GcCreatureGenerationData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x000 */ public GcCreatureGenerationOptionalWeightedList[] SubBiomeSpecific;
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x798 */ public GcCreatureGenerationOptionalWeightedList[] BiomeSpecific;
        [NMS(Index = 2)]
        /* 0xC18 */ public GcCreatureGenerationOptionalWeightedList AbandonedSystemSpecific;
        [NMS(Index = 3)]
        /* 0xC60 */ public GcCreatureGenerationOptionalWeightedList EmptySystemSpecific;
        [NMS(Index = 4)]
        /* 0xCA8 */ public GcCreatureGenerationWeightedList Generic;
        [NMS(Index = 5)]
        /* 0xCE8 */ public List<GcCreatureGenerationWeightedListDomainEntry> AirArchetypesForEmptyGround;
        [NMS(Index = 6, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xCF8 */ public float[] SandwormPresenceChance;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD38 */ public float[] AirGroupsPerKm;
        [NMS(Index = 13, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD48 */ public float[] CaveGroupsPerKm;
        [NMS(Index = 14, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD58 */ public float[] DensityModifiers;
        [NMS(Index = 10, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD68 */ public float[] GroundGroupsPerKm;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xD78 */ public float[] LifeChance;
        [NMS(Index = 15, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xD88 */ public float[] LifeLevelDensityModifiers;
        [NMS(Index = 9, Size = 0x4, EnumType = typeof(GcCreatureRarity.CreatureRarityEnum))]
        /* 0xD98 */ public float[] RarityFrequencyModifiers;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0xDA8 */ public float[] RoleFrequencyModifiers;
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xDB8 */ public float[] WaterGroupsPerKm;
        [NMS(Index = 16)]
        /* 0xDC8 */ public float HerdCreaturePenalty;
    }
}
