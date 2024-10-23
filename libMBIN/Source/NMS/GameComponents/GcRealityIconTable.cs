using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BE83B81C8BB967F, NameHash = 0xA547E834)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Index = 15, Size = 0x5C, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x0000 */ public TkTextureResource[] GameIcons;
        [NMS(Index = 5, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x08A0 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Index = 4, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x0A38 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Index = 3, Size = 0xA, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0B28 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Index = 8, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0C18 */ public TkTextureResource[] DiscoveryPageRaceIcons;
        [NMS(Index = 2, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0CF0 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Index = 17, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x0DC8 */ public TkTextureResource[] DifficultyPresetIcons;
        [NMS(Index = 6, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x0E70 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0F18 */ public TkTextureResource[] HazardIcons;
        [NMS(Index = 1, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0FC0 */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Index = 20, Size = 0x5, EnumType = typeof(GcInventoryFilterOptions.InventoryFilterEnum))]
        /* 0x1068 */ public TkTextureResource[] InventoryFilterIcons;
        [NMS(Index = 19, Size = 0x5, EnumType = typeof(GcOptionsUIHeaderIcons.OptionsUIHeaderIconTypeEnum))]
        /* 0x10E0 */ public TkTextureResource[] OptionsUIHeaderIcons;
        [NMS(Index = 18, Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x1158 */ public TkTextureResource[] DifficultyUIOptionIcons;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x11B8 */ public TkTextureResource[] DiscoveryPageConflictIcons;
        [NMS(Index = 16)]
        /* 0x1218 */ public HashMap<GcRealityIcon> MissionDetailIcons;
        [NMS(Index = 10)]
        /* 0x1248 */ public TkTextureResource DiscoveryPageConflictUnknown;
        [NMS(Index = 11)]
        /* 0x1260 */ public TkTextureResource DiscoveryPageRaceUnknown;
        [NMS(Index = 9)]
        /* 0x1278 */ public TkTextureResource DiscoveryPageTradingUnknown;
        [NMS(Index = 13)]
        /* 0x1290 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        [NMS(Index = 14)]
        /* 0x12A0 */ public List<TkTextureResource> RepairTechIcons;
        [NMS(Index = 12)]
        /* 0x12B0 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
    }
}
