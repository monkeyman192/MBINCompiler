using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DBF4D2551B6BF99, NameHash = 0x1BA21E88)]
    public class GcCreatureGenerationData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x1C, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x000 */ public GcCreatureGenerationOptionalWeightedList[] SubBiomeSpecific;
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x7E0 */ public GcCreatureGenerationOptionalWeightedList[] BiomeSpecific;
        [NMS(Index = 2)]
        /* 0xC60 */ public GcCreatureGenerationOptionalWeightedList AbandonedSystemSpecific;
        [NMS(Index = 3)]
        /* 0xCA8 */ public GcCreatureGenerationOptionalWeightedList EmptySystemSpecific;
        [NMS(Index = 5)]
        /* 0xCF0 */ public GcCreatureGenerationOptionalWeightedList PurpleEmptySystemSpecific;
        [NMS(Index = 4)]
        /* 0xD38 */ public GcCreatureGenerationOptionalWeightedList PurpleSystemSpecific;
        [NMS(Index = 6)]
        /* 0xD80 */ public GcCreatureGenerationWeightedList Generic;
        [NMS(Index = 7)]
        /* 0xDC0 */ public List<GcCreatureGenerationWeightedListDomainEntry> AirArchetypesForEmptyGround;
        [NMS(Index = 8, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xDD0 */ public float[] SandwormPresenceChance;
        [NMS(Index = 14, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xE10 */ public float[] AirGroupsPerKm;
        [NMS(Index = 15, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xE20 */ public float[] CaveGroupsPerKm;
        [NMS(Index = 16, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xE30 */ public float[] DensityModifiers;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xE40 */ public float[] GroundGroupsPerKm;
        [NMS(Index = 9, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xE50 */ public float[] LifeChance;
        [NMS(Index = 17, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xE60 */ public float[] LifeLevelDensityModifiers;
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(GcCreatureRarity.CreatureRarityEnum))]
        /* 0xE70 */ public float[] RarityFrequencyModifiers;
        [NMS(Index = 10, Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0xE80 */ public float[] RoleFrequencyModifiers;
        [NMS(Index = 13, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xE90 */ public float[] WaterGroupsPerKm;
        [NMS(Index = 18)]
        /* 0xEA0 */ public float HerdCreaturePenalty;
    }
}
