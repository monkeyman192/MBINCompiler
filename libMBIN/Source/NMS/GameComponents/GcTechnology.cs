using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x350, GUID = 0x36849C3AB2719329, NameHash = 0x9F1CE8466638E767)]
    public class GcTechnology : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string Group;
        [NMS(Size = 0x80)]
        /* 0x030 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x0B0 */ public string NameLower;
        /* 0x130 */ public VariableSizeString Subtitle;
        /* 0x140 */ public VariableSizeString Description;
        /* 0x150 */ public bool Teach;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x151 */ public byte[] Padding151;

        [NMS(Size = 0x20)]
        /* 0x158 */ public string HintStart;

        [NMS(Size = 0x20)]
        /* 0x178 */ public string HintEnd;

        /* 0x198 */ public TkTextureResource Icon;

        /* 0x220 */ public Colour Colour;
        /* 0x230 */ public int Level;
        /* 0x234 */ public bool Chargeable;
        /* 0x238 */ public int ChargeAmount;

        /* 0x23C */ public GcRealitySubstanceCategory ChargeType;
        /* 0x240 */ public List<NMSString0x10> ChargeBy;
        /* 0x250 */ public float ChargeMultiplier;
        /* 0x254 */ public bool BuildFullyCharged;
        /* 0x255 */ public bool UsesAmmo;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x256 */ public byte[] Padding256;
        [NMS(Size = 0x10)]
        /* 0x258 */ public string AmmoId;
        /* 0x268 */ public bool PrimaryItem;
        /* 0x269 */ public bool Upgrade;
        /* 0x26A */ public bool Core;
        /* 0x26B */ public bool RepairTech;
        /* 0x26C */ public bool Procedural;
        /* 0x270 */ public GcTechnologyCategory TechnologyCategory;
        /* 0x274 */ public GcTechnologyRarity TechnologyRarity;
        /* 0x278 */ public float Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x27C */ public byte[] Padding27C;
        /* 0x280 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x290 */ public GcStatsTypes BaseStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x294 */ public byte[] Padding294;
        /* 0x298 */ public List<GcStatsBonus> StatBonuses;
        [NMS(Size = 0x10)]
        /* 0x2A8 */ public string RequiredTech;
        /* 0x2B8 */ public int RequiredLevel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2BC */ public byte[] Padding2BC;
        [NMS(Size = 0x20)]
        /* 0x2C0 */ public string FocusLocator;
        /* 0x2E0 */ public Colour UpgradeColour;
        /* 0x2F0 */ public Colour LinkColour;
        [NMS(Size = 0x10)]
        /* 0x300 */ public string RewardGroup;
        /* 0x310 */ public int BaseValue;
        /* 0x314 */ public GcItemPriceModifiers Cost;
        /* 0x328 */ public int RequiredRank;
        /* 0x32C */ public GcAlienRace DispensingRace;
        /* 0x330 */ public int FragmentCost;
        /* 0x334 */ public GcTechnologyRarity TechShopRarity;
        /* 0x338 */ public bool WikiEnabled;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x339 */ public byte[] Padding339;
        /* 0x340 */ public VariableSizeString DamagedDescription;
    }
}
