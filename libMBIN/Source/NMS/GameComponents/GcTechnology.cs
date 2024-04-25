using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9687EF15CEEF3FE9, NameHash = 0x9F1CE8466638E767)]
    public class GcTechnology : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 36)]
        /* 0x010 */ public Colour LinkColour;
        [NMS(Index = 35)]
        /* 0x020 */ public Colour UpgradeColour;
        [NMS(Index = 34)]
        /* 0x030 */ public NMSString0x20A FocusLocator;
        [NMS(Index = 1)]
        /* 0x050 */ public NMSString0x20A Group;
        [NMS(Index = 8)]
        /* 0x070 */ public NMSString0x20A HintEnd;
        [NMS(Index = 7)]
        /* 0x090 */ public NMSString0x20A HintStart;
        [NMS(Index = 19)]
        /* 0x0B0 */ public NMSString0x10 AmmoId;
        [NMS(Index = 15)]
        /* 0x0C0 */ public List<NMSString0x10> ChargeBy;
        [NMS(Index = 45)]
        /* 0x0D0 */ public VariableSizeString DamagedDescription;
        [NMS(Index = 5)]
        /* 0x0E0 */ public VariableSizeString Description;
        [NMS(Index = 0)]
        /* 0x0F0 */ public NMSString0x10 ID;
        [NMS(Index = 46)]
        /* 0x100 */ public NMSString0x10 ParentTechId;
        [NMS(Index = 32)]
        /* 0x110 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 29)]
        /* 0x120 */ public List<GcTechnologyRequirement> Requirements;
        [NMS(Index = 37)]
        /* 0x130 */ public NMSString0x10 RewardGroup;
        [NMS(Index = 31)]
        /* 0x140 */ public List<GcStatsBonus> StatBonuses;
        [NMS(Index = 4)]
        /* 0x150 */ public VariableSizeString Subtitle;
        [NMS(Index = 9)]
        /* 0x160 */ public TkTextureResource Icon;
        [NMS(Index = 39)]
        /* 0x1E4 */ public GcItemPriceModifiers Cost;
        [NMS(Index = 30)]
        /* 0x1F8 */ public GcStatsTypes BaseStat;
        [NMS(Index = 38)]
        /* 0x1FC */ public int BaseValue;
        [NMS(Index = 26)]
        /* 0x200 */ public GcTechnologyCategory Category;
        [NMS(Index = 13)]
        /* 0x204 */ public int ChargeAmount;
        [NMS(Index = 16)]
        /* 0x208 */ public float ChargeMultiplier;
        [NMS(Index = 14)]
        /* 0x20C */ public GcRealitySubstanceCategory ChargeType;
        [NMS(Index = 41)]
        /* 0x210 */ public GcAlienRace DispensingRace;
        [NMS(Index = 42)]
        /* 0x214 */ public int FragmentCost;
        [NMS(Index = 11)]
        /* 0x218 */ public int Level;
        [NMS(Index = 27)]
        /* 0x21C */ public GcTechnologyRarity Rarity;
        [NMS(Index = 33)]
        /* 0x220 */ public int RequiredLevel;
        [NMS(Index = 40)]
        /* 0x224 */ public int RequiredRank;
        [NMS(Index = 43)]
        /* 0x228 */ public GcTechnologyRarity TechShopRarity;
        [NMS(Index = 28)]
        /* 0x22C */ public float Value;
        [NMS(Index = 2)]
        /* 0x230 */ public NMSString0x80 Name;
        [NMS(Index = 3)]
        /* 0x2B0 */ public NMSString0x80 NameLower;
        [NMS(Index = 25)]
        /* 0x330 */ public bool BrokenSlotTech;
        [NMS(Index = 17)]
        /* 0x331 */ public bool BuildFullyCharged;
        [NMS(Index = 12)]
        /* 0x332 */ public bool Chargeable;
        [NMS(Index = 22)]
        /* 0x333 */ public bool Core;
        [NMS(Index = 48)]
        /* 0x334 */ public bool ExclusivePrimaryStat;
        [NMS(Index = 47)]
        /* 0x335 */ public bool IsTemplate;
        [NMS(Index = 20)]
        /* 0x336 */ public bool PrimaryItem;
        [NMS(Index = 24)]
        /* 0x337 */ public bool Procedural;
        [NMS(Index = 23)]
        /* 0x338 */ public bool RepairTech;
        [NMS(Index = 6)]
        /* 0x339 */ public bool Teach;
        [NMS(Index = 21)]
        /* 0x33A */ public bool Upgrade;
        [NMS(Index = 18)]
        /* 0x33B */ public bool UsesAmmo;
        [NMS(Index = 44)]
        /* 0x33C */ public bool WikiEnabled;
    }
}
