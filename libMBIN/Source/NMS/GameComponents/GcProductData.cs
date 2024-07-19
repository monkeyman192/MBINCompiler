using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC28073B0A7837CCE, NameHash = 0x5C7DD06F)]
    public class GcProductData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 5)]
        /* 0x010 */ public NMSString0x20A Hint;
        [NMS(Index = 35)]
        /* 0x030 */ public NMSString0x20A PinObjective;
        [NMS(Index = 37)]
        /* 0x050 */ public NMSString0x20A PinObjectiveMessage;
        [NMS(Index = 36)]
        /* 0x070 */ public NMSString0x20A PinObjectiveTip;
        [NMS(Index = 7)]
        /* 0x090 */ public TkModelResource DebrisFile;
        [NMS(Index = 11)]
        /* 0x0A8 */ public TkTextureResource HeroIcon;
        [NMS(Index = 10)]
        /* 0x0C0 */ public TkTextureResource Icon;
        [NMS(Index = 24)]
        /* 0x0D8 */ public List<GcTechnologyRequirement> AltRequirements;
        [NMS(Index = 33)]
        /* 0x0E8 */ public NMSString0x10 DeploysInto;
        [NMS(Index = 4)]
        /* 0x0F8 */ public VariableSizeString Description;
        [NMS(Index = 43)]
        /* 0x108 */ public NMSString0x10 GiveRewardOnSpecialPurchase;
        [NMS(Index = 6)]
        /* 0x118 */ public NMSString0x10 GroupID;
        [NMS(Index = 0)]
        /* 0x128 */ public NMSString0x10 ID;
        [NMS(Index = 23)]
        /* 0x138 */ public List<GcTechnologyRequirement> Requirements;
        [NMS(Index = 3)]
        /* 0x148 */ public VariableSizeString Subtitle;
        [NMS(Index = 25)]
        /* 0x158 */ public GcItemPriceModifiers Cost;
        [NMS(Index = 8)]
        /* 0x16C */ public int BaseValue;
        [NMS(Index = 13)]
        /* 0x170 */ public GcRealitySubstanceCategory Category;
        [NMS(Index = 18)]
        /* 0x174 */ public int ChargeValue;
        [NMS(Index = 41)]
        /* 0x178 */ public float CookingValue;
        [NMS(Index = 22)]
        /* 0x17C */ public int CraftAmountMultiplier;
        [NMS(Index = 21)]
        /* 0x180 */ public int CraftAmountStepSize;
        [NMS(Index = 20)]
        /* 0x184 */ public int DefaultCraftAmount;
        [NMS(Index = 34)]
        /* 0x188 */ public float EconomyInfluenceMultiplier;
        [NMS(Index = 16)]
        /* 0x18C */ public GcLegality Legality;
        [NMS(Index = 9)]
        /* 0x190 */ public int Level;
        [NMS(Index = 29)]
        /* 0x194 */ public float NormalisedValueOffWorld;
        [NMS(Index = 28)]
        /* 0x198 */ public float NormalisedValueOnWorld;
        [NMS(Index = 38)]
        /* 0x19C */ public GcScannerIconTypes PinObjectiveScannableType;
        [NMS(Index = 15)]
        /* 0x1A0 */ public GcRarity Rarity;
        [NMS(Index = 26)]
        /* 0x1A4 */ public int RecipeCost;
        [NMS(Index = 19)]
        /* 0x1A8 */ public int StackMultiplier;
        [NMS(Index = 30)]
        /* 0x1AC */ public GcTradeCategory TradeCategory;
        [NMS(Index = 14)]
        /* 0x1B0 */ public GcProductCategory Type;
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
        [NMS(Index = 31)]
        /* 0x1B4 */ public WikiCategoryEnum WikiCategory;
        [NMS(Index = 1)]
        /* 0x1B8 */ public NMSString0x80 Name;
        [NMS(Index = 2)]
        /* 0x238 */ public NMSString0x80 NameLower;
        [NMS(Index = 46)]
        /* 0x2B8 */ public bool CanSendToOtherPlayers;
        [NMS(Index = 17)]
        /* 0x2B9 */ public bool Consumable;
        [NMS(Index = 40)]
        /* 0x2BA */ public bool CookingIngredient;
        [NMS(Index = 44)]
        /* 0x2BB */ public bool EggModifierIngredient;
        [NMS(Index = 42)]
        /* 0x2BC */ public bool GoodForSelling;
        [NMS(Index = 32)]
        /* 0x2BD */ public bool IsCraftable;
        [NMS(Index = 45)]
        /* 0x2BE */ public bool IsTechbox;
        [NMS(Index = 39)]
        /* 0x2BF */ public bool PinObjectiveEasyToRefine;
        [NMS(Index = 27)]
        /* 0x2C0 */ public bool SpecificChargeOnly;
    }
}
