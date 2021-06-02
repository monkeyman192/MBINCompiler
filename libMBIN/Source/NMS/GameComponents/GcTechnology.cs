using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x360, GUID = 0x2D72DDC037724378, NameHash = 0x9F1CE8466638E767)]
    public class GcTechnology : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x020 */ public NMSString0x20A Group;
        /* 0x030 */ public NMSString0x80 Name;
        /* 0x0B0 */ public NMSString0x80 NameLower;
        /* 0x130 */ public VariableSizeString Subtitle;
        /* 0x140 */ public VariableSizeString Description;
        /* 0x150 */ public bool Teach;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x151 */ public byte[] Padding151;
        /* 0x158 */ public NMSString0x20A HintStart;
        /* 0x178 */ public NMSString0x20A HintEnd;
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
        /* 0x258 */ public NMSString0x10 AmmoId;
        /* 0x268 */ public bool PrimaryItem;
        /* 0x269 */ public bool Upgrade;
        /* 0x26A */ public bool Core;
        /* 0x26B */ public bool RepairTech;
        /* 0x26C */ public bool Procedural;
        /* 0x270 */ public GcTechnologyCategory Category;
        /* 0x274 */ public GcTechnologyRarity Rarity;
        /* 0x278 */ public float Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x27C */ public byte[] Padding27C;
        /* 0x280 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x290 */ public GcStatsTypes BaseStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x294 */ public byte[] Padding294;
        /* 0x298 */ public List<GcStatsBonus> StatBonuses;
        /* 0x2A8 */ public NMSString0x10 RequiredTech;
        /* 0x2B8 */ public int RequiredLevel;
        /* 0x2C0 */ public NMSString0x20A FocusLocator;
        /* 0x2E0 */ public Colour UpgradeColour;
        /* 0x2F0 */ public Colour LinkColour;
        /* 0x300 */ public NMSString0x10 RewardGroup;
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
        /* 0x350 */ public NMSString0x10 ParentTechId;
    }
}
