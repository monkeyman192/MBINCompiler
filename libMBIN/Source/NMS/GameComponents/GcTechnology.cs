using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9687EF15CEEF3FE9, NameHash = 0x9F1CE8466638E767)]
    public class GcTechnology : NMSTemplate
    {
        /* 0x000 */ public Colour Colour;
        /* 0x010 */ public Colour LinkColour;
        /* 0x020 */ public Colour UpgradeColour;
        /* 0x030 */ public NMSString0x20A FocusLocator;
        /* 0x050 */ public NMSString0x20A Group;
        /* 0x070 */ public NMSString0x20A HintEnd;
        /* 0x090 */ public NMSString0x20A HintStart;
        /* 0x0B0 */ public NMSString0x10 AmmoId;
        /* 0x0C0 */ public List<NMSString0x10> ChargeBy;
        /* 0x0D0 */ public VariableSizeString DamagedDescription;
        /* 0x0E0 */ public VariableSizeString Description;
        /* 0x0F0 */ public NMSString0x10 ID;
        /* 0x100 */ public NMSString0x10 ParentTechId;
        /* 0x110 */ public NMSString0x10 RequiredTech;
        /* 0x120 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x130 */ public NMSString0x10 RewardGroup;
        /* 0x140 */ public List<GcStatsBonus> StatBonuses;
        /* 0x150 */ public VariableSizeString Subtitle;
        /* 0x160 */ public TkTextureResource Icon;
        /* 0x1E4 */ public GcItemPriceModifiers Cost;
        /* 0x1F8 */ public GcStatsTypes BaseStat;
        /* 0x1FC */ public int BaseValue;
        /* 0x200 */ public GcTechnologyCategory Category;
        /* 0x204 */ public int ChargeAmount;
        /* 0x208 */ public float ChargeMultiplier;
        /* 0x20C */ public GcRealitySubstanceCategory ChargeType;
        /* 0x210 */ public GcAlienRace DispensingRace;
        /* 0x214 */ public int FragmentCost;
        /* 0x218 */ public int Level;
        /* 0x21C */ public GcTechnologyRarity Rarity;
        /* 0x220 */ public int RequiredLevel;
        /* 0x224 */ public int RequiredRank;
        /* 0x228 */ public GcTechnologyRarity TechShopRarity;
        /* 0x22C */ public float Value;
        /* 0x230 */ public NMSString0x80 Name;
        /* 0x2B0 */ public NMSString0x80 NameLower;
        /* 0x330 */ public bool BrokenSlotTech;
        /* 0x331 */ public bool BuildFullyCharged;
        /* 0x332 */ public bool Chargeable;
        /* 0x333 */ public bool Core;
        /* 0x334 */ public bool ExclusivePrimaryStat;
        /* 0x335 */ public bool IsTemplate;
        /* 0x336 */ public bool PrimaryItem;
        /* 0x337 */ public bool Procedural;
        /* 0x338 */ public bool RepairTech;
        /* 0x339 */ public bool Teach;
        /* 0x33A */ public bool Upgrade;
        /* 0x33B */ public bool UsesAmmo;
        /* 0x33C */ public bool WikiEnabled;
    }
}
