using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6889644F70A02214, NameHash = 0x4742E3FE43A533C7)]
    public class GcCreatureGenerationData : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcCreatureGenerationOptionalWeightedList[] BiomeSpecific;
        [NMS(Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x480 */ public GcCreatureGenerationOptionalWeightedList[] SubBiomeSpecific;
        /* 0xC18 */ public GcCreatureGenerationOptionalWeightedList AbandonedSystemSpecific;
        /* 0xC60 */ public GcCreatureGenerationOptionalWeightedList EmptySystemSpecific;
        /* 0xCA8 */ public GcCreatureGenerationWeightedList Generic;
        /* 0xCE8 */ public List<GcCreatureGenerationWeightedListDomainEntry> AirArchetypesForEmptyGround;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xCF8 */ public float[] SandwormPresenceChance;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xD38 */ public float[] LifeChance;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0xD48 */ public float[] RoleFrequencyModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureRarity.CreatureRarityEnum))]
        /* 0xD58 */ public float[] RarityFrequencyModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD68 */ public float[] GroundGroupsPerKm;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD78 */ public float[] WaterGroupsPerKm;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD88 */ public float[] AirGroupsPerKm;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xD98 */ public float[] CaveGroupsPerKm;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xDA8 */ public float[] DensityModifiers;
        [NMS(Size = 0x4)]
        /* 0xDB8 */ public float[] LifeLevelDensityModifiers;
        /* 0xDE8 */ public float HerdCreaturePenalty;
    }
}
