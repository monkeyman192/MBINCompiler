using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x383A0AC2EEDD879D, NameHash = 0x77AFB727)]
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
        [NMS(Index = 9)]
        /* 0x0B0 */ public TkTextureResource Icon;
        [NMS(Index = 19)]
        /* 0x0C8 */ public NMSString0x10 AmmoId;
        [NMS(Index = 15)]
        /* 0x0D8 */ public List<NMSString0x10> ChargeBy;
        [NMS(Index = 45)]
        /* 0x0E8 */ public VariableSizeString DamagedDescription;
        [NMS(Index = 5)]
        /* 0x0F8 */ public VariableSizeString Description;
        [NMS(Index = 0)]
        /* 0x108 */ public NMSString0x10 ID;
        [NMS(Index = 46)]
        /* 0x118 */ public NMSString0x10 ParentTechId;
        [NMS(Index = 32)]
        /* 0x128 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 29)]
        /* 0x138 */ public List<GcTechnologyRequirement> Requirements;
        [NMS(Index = 37)]
        /* 0x148 */ public NMSString0x10 RewardGroup;
        [NMS(Index = 31)]
        /* 0x158 */ public List<GcStatsBonus> StatBonuses;
        [NMS(Index = 4)]
        /* 0x168 */ public VariableSizeString Subtitle;
        [NMS(Index = 39)]
        /* 0x178 */ public GcItemPriceModifiers Cost;
        [NMS(Index = 30)]
        /* 0x18C */ public GcStatsTypes BaseStat;
        [NMS(Index = 38)]
        /* 0x190 */ public int BaseValue;
        [NMS(Index = 26)]
        /* 0x194 */ public GcTechnologyCategory Category;
        [NMS(Index = 13)]
        /* 0x198 */ public int ChargeAmount;
        [NMS(Index = 16)]
        /* 0x19C */ public float ChargeMultiplier;
        [NMS(Index = 14)]
        /* 0x1A0 */ public GcRealitySubstanceCategory ChargeType;
        [NMS(Index = 41)]
        /* 0x1A4 */ public GcAlienRace DispensingRace;
        [NMS(Index = 42)]
        /* 0x1A8 */ public int FragmentCost;
        [NMS(Index = 11)]
        /* 0x1AC */ public int Level;
        [NMS(Index = 27)]
        /* 0x1B0 */ public GcTechnologyRarity Rarity;
        [NMS(Index = 33)]
        /* 0x1B4 */ public int RequiredLevel;
        [NMS(Index = 40)]
        /* 0x1B8 */ public int RequiredRank;
        [NMS(Index = 43)]
        /* 0x1BC */ public GcTechnologyRarity TechShopRarity;
        [NMS(Index = 28)]
        /* 0x1C0 */ public float Value;
        [NMS(Index = 2)]
        /* 0x1C4 */ public NMSString0x80 Name;
        [NMS(Index = 3)]
        /* 0x244 */ public NMSString0x80 NameLower;
        [NMS(Index = 25)]
        /* 0x2C4 */ public bool BrokenSlotTech;
        [NMS(Index = 17)]
        /* 0x2C5 */ public bool BuildFullyCharged;
        [NMS(Index = 12)]
        /* 0x2C6 */ public bool Chargeable;
        [NMS(Index = 22)]
        /* 0x2C7 */ public bool Core;
        [NMS(Index = 48)]
        /* 0x2C8 */ public bool ExclusivePrimaryStat;
        [NMS(Index = 47)]
        /* 0x2C9 */ public bool IsTemplate;
        [NMS(Index = 20)]
        /* 0x2CA */ public bool PrimaryItem;
        [NMS(Index = 24)]
        /* 0x2CB */ public bool Procedural;
        [NMS(Index = 23)]
        /* 0x2CC */ public bool RepairTech;
        [NMS(Index = 6)]
        /* 0x2CD */ public bool Teach;
        [NMS(Index = 21)]
        /* 0x2CE */ public bool Upgrade;
        [NMS(Index = 18)]
        /* 0x2CF */ public bool UsesAmmo;
        [NMS(Index = 44)]
        /* 0x2D0 */ public bool WikiEnabled;
    }
}
