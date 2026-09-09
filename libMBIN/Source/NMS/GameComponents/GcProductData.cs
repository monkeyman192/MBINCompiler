using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9DC02BF5FB4B687, NameHash = 0x5C7DD06F)]
    public class GcProductData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 9)]
        /* 0x010 */ public TkModelResource DebrisFile;
        [NMS(Index = 6)]
        /* 0x030 */ public NMSString0x20A Hint;
        [NMS(Index = 40)]
        /* 0x050 */ public NMSString0x20A PinObjective;
        [NMS(Index = 42)]
        /* 0x070 */ public NMSString0x20A PinObjectiveMessage;
        [NMS(Index = 41)]
        /* 0x090 */ public NMSString0x20A PinObjectiveTip;
        [NMS(Index = 13)]
        /* 0x0B0 */ public TkTextureResource HeroIcon;
        [NMS(Index = 12)]
        /* 0x0C8 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0x0E0 */ public VariableSizeString AltDescription;
        [NMS(Index = 26)]
        /* 0x0F0 */ public List<GcTechnologyRequirement> AltRequirements;
        [NMS(Index = 7)]
        /* 0x100 */ public NMSString0x10 BuildableShipTechID;
        [NMS(Index = 38)]
        /* 0x110 */ public NMSString0x10 DeploysInto;
        [NMS(Index = 4)]
        /* 0x120 */ public VariableSizeString Description;
        [NMS(Index = 51)]
        /* 0x130 */ public NMSString0x10 GiveRewardOnSpecialPurchase;
        [NMS(Index = 8)]
        /* 0x140 */ public NMSString0x10 GroupID;
        [NMS(Index = 0)]
        /* 0x150 */ public NMSString0x10 ID;
        [NMS(Index = 25)]
        /* 0x160 */ public List<GcTechnologyRequirement> Requirements;
        [NMS(Index = 3)]
        /* 0x170 */ public VariableSizeString Subtitle;
        [NMS(Index = 27)]
        /* 0x180 */ public GcItemPriceModifiers Cost;
        [NMS(Index = 10)]
        /* 0x194 */ public int BaseValue;
        [NMS(Index = 15)]
        /* 0x198 */ public GcRealitySubstanceCategory Category;
        [NMS(Index = 20)]
        /* 0x19C */ public int ChargeValue;
        [NMS(Index = 47)]
        /* 0x1A0 */ public float CookingValue;
        [NMS(Index = 35)]
        /* 0x1A4 */ public GcCorvettePartCategory CorvettePartCategory;
        [NMS(Index = 36)]
        /* 0x1A8 */ public float CorvetteRewardFrequency;
        [NMS(Index = 24)]
        /* 0x1AC */ public int CraftAmountMultiplier;
        [NMS(Index = 23)]
        /* 0x1B0 */ public int CraftAmountStepSize;
        [NMS(Index = 22)]
        /* 0x1B4 */ public int DefaultCraftAmount;
        [NMS(Index = 39)]
        /* 0x1B8 */ public float EconomyInfluenceMultiplier;
        [NMS(Index = 48)]
        /* 0x1BC */ public GcStatsTypes FoodBonusStat;
        [NMS(Index = 49)]
        /* 0x1C0 */ public float FoodBonusStatAmount;
        [NMS(Index = 34)]
        /* 0x1C4 */ public GcFossilCategory FossilCategory;
        [NMS(Index = 18)]
        /* 0x1C8 */ public GcLegality Legality;
        [NMS(Index = 11)]
        /* 0x1CC */ public int Level;
        [NMS(Index = 31)]
        /* 0x1D0 */ public float NormalisedValueOffWorld;
        [NMS(Index = 30)]
        /* 0x1D4 */ public float NormalisedValueOnWorld;
        [NMS(Index = 17)]
        /* 0x1D8 */ public GcRarity Rarity;
        [NMS(Index = 28)]
        /* 0x1DC */ public int RecipeCost;
        [NMS(Index = 21)]
        /* 0x1E0 */ public int StackMultiplier;
        [NMS(Index = 32)]
        /* 0x1E4 */ public GcTradeCategory TradeCategory;
        [NMS(Index = 16)]
        /* 0x1E8 */ public GcProductCategory Type;
        // size: 0x7
        public enum WikiCategoryEnum : uint {
            NotEnabled,
            Crafting,
            Tech,
            Construction,
            Trade,
            Curio,
            Cooking,
        }
        [NMS(Index = 33)]
        /* 0x1EC */ public WikiCategoryEnum WikiCategory;
        [NMS(Index = 1)]
        /* 0x1F0 */ public NMSString0x80 Name;
        [NMS(Index = 2)]
        /* 0x270 */ public NMSString0x80 NameLower;
        [NMS(Index = 54)]
        /* 0x2F0 */ public bool CanSendToOtherPlayers;
        [NMS(Index = 19)]
        /* 0x2F1 */ public bool Consumable;
        [NMS(Index = 46)]
        /* 0x2F2 */ public bool CookingIngredient;
        [NMS(Index = 52)]
        /* 0x2F3 */ public bool EggModifierIngredient;
        [NMS(Index = 50)]
        /* 0x2F4 */ public bool GoodForSelling;
        [NMS(Index = 37)]
        /* 0x2F5 */ public bool IsCraftable;
        [NMS(Index = 53)]
        /* 0x2F6 */ public bool IsTechbox;
        [NMS(Index = 45)]
        /* 0x2F7 */ public bool NeverPinnable;
        [NMS(Index = 44)]
        /* 0x2F8 */ public bool PinObjectiveEasyToRefine;
        [NMS(Index = 43)]
        /* 0x2F9 */ public GcScannerIconTypes PinObjectiveScannableType;
        [NMS(Index = 29)]
        /* 0x2FA */ public bool SpecificChargeOnly;
    }
}
