using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC7CA061653F89A1, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x0000 */ public List<GcRealityIcon> MissionDetailIcons;
        [NMS(Index = 13)]
        /* 0x0010 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        [NMS(Index = 14)]
        /* 0x0020 */ public List<TkTextureResource> RepairTechIcons;
        [NMS(Index = 12)]
        /* 0x0030 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        [NMS(Index = 15, Size = 0x59, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x0040 */ public TkTextureResource[] GameIcons;
        [NMS(Index = 5, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x2E24 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Index = 4, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x36E8 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Index = 8, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x3C10 */ public TkTextureResource[] DiscoveryPageRaceIcons;
        [NMS(Index = 3, Size = 0x9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x40B4 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Index = 2, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x4558 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Index = 17, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x49FC */ public TkTextureResource[] DifficultyPresetIcons;
        [NMS(Index = 6, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x4D98 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x5134 */ public TkTextureResource[] HazardIcons;
        [NMS(Index = 1, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x544C */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Index = 20, Size = 0x5, EnumType = typeof(GcInventoryFilterOptions.InventoryFilterEnum))]
        /* 0x5764 */ public TkTextureResource[] InventoryFilterIcons;
        [NMS(Index = 19, Size = 0x5, EnumType = typeof(GcOptionsUIHeaderIcons.OptionsUIHeaderIconTypeEnum))]
        /* 0x59F8 */ public TkTextureResource[] OptionsUIHeaderIcons;
        [NMS(Index = 18, Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x5C8C */ public TkTextureResource[] DifficultyUIOptionIcons;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x5E9C */ public TkTextureResource[] DiscoveryPageConflictIcons;
        [NMS(Index = 10)]
        /* 0x60AC */ public TkTextureResource DiscoveryPageConflictUnknown;
        [NMS(Index = 11)]
        /* 0x6130 */ public TkTextureResource DiscoveryPageRaceUnknown;
        [NMS(Index = 9)]
        /* 0x61B4 */ public TkTextureResource DiscoveryPageTradingUnknown;
    }
}
