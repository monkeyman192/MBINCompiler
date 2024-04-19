using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC7CA061653F89A1, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        /* 0x0000 */ public List<GcRealityIcon> MissionDetailIcons;
        /* 0x0010 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x0020 */ public List<TkTextureResource> RepairTechIcons;
        /* 0x0030 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        [NMS(Size = 0x59, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x0040 */ public TkTextureResource[] GameIcons;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x2E24 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x36E8 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x3C10 */ public TkTextureResource[] DiscoveryPageRaceIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x40B4 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x4558 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x49FC */ public TkTextureResource[] DifficultyPresetIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x4D98 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x5134 */ public TkTextureResource[] HazardIcons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x544C */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Size = 0x5, EnumType = typeof(GcInventoryFilterOptions.InventoryFilterEnum))]
        /* 0x5764 */ public TkTextureResource[] InventoryFilterIcons;
        [NMS(Size = 0x5, EnumType = typeof(GcOptionsUIHeaderIcons.OptionsUIHeaderIconTypeEnum))]
        /* 0x59F8 */ public TkTextureResource[] OptionsUIHeaderIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x5C8C */ public TkTextureResource[] DifficultyUIOptionIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x5E9C */ public TkTextureResource[] DiscoveryPageConflictIcons;
        /* 0x60AC */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x6130 */ public TkTextureResource DiscoveryPageRaceUnknown;
        /* 0x61B4 */ public TkTextureResource DiscoveryPageTradingUnknown;
    }
}
