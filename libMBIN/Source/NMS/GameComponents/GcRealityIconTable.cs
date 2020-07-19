using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4B08, GUID = 0x2AD346B04A54A12F, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;

        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0318 */ public TkTextureResource[] SubstanceCategoryIcons;

        [NMS(Size = 0x8, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x07BC */ public TkTextureResource[] ProductCategoryIcons;

        [NMS(Size = 0x8, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x0BDC */ public TkTextureResource[] MissionFactionIcons;

        [NMS(Size = 0x10, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0FFC */ public TkTextureResource[] BinocularDiscoveryIcons;

        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x183C */ public TkTextureResource[] DiscoveryPageTradingIcons;

        [NMS(Size = 0x3, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1BD8 */ public TkTextureResource[] DiscoveryPageConflictIcons;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1D64 */ public TkTextureResource[] DiscoveryPageRaceIcons;

        /* 0x2184 */ public TkTextureResource DiscoveryPageTradingUnknown;
        /* 0x2208 */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x228C */ public TkTextureResource DiscoveryPageRaceUnknown;

        /* 0x2310 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2320 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2330 */ public List<TkTextureResource> RepairTechIcons;

        [NMS(Size = 0x4D, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x2340 */ public TkTextureResource[] GameIcons;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4AF4 */ public byte[] Padding4AF4;
        /* 0x4AF8 */ public List<GcRealityIcon> MissionDetailIcons;
    }
}
