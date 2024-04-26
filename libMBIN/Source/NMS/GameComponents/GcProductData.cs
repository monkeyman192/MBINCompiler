using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x268CAA7D7CCCB649, NameHash = 0xE831C8A241FD8276)]
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
        [NMS(Index = 24)]
        /* 0x090 */ public List<GcTechnologyRequirement> AltRequirements;
        [NMS(Index = 33)]
        /* 0x0A0 */ public NMSString0x10 DeploysInto;
        [NMS(Index = 4)]
        /* 0x0B0 */ public VariableSizeString Description;
        [NMS(Index = 43)]
        /* 0x0C0 */ public NMSString0x10 GiveRewardOnSpecialPurchase;
        [NMS(Index = 6)]
        /* 0x0D0 */ public NMSString0x10 GroupID;
        [NMS(Index = 0)]
        /* 0x0E0 */ public NMSString0x10 ID;
        [NMS(Index = 23)]
        /* 0x0F0 */ public List<GcTechnologyRequirement> Requirements;
        [NMS(Index = 3)]
        /* 0x100 */ public VariableSizeString Subtitle;
        [NMS(Index = 7)]
        /* 0x110 */ public TkModelResource DebrisFile;
        [NMS(Index = 11)]
        /* 0x194 */ public TkTextureResource HeroIcon;
        [NMS(Index = 10)]
        /* 0x218 */ public TkTextureResource Icon;
        [NMS(Index = 25)]
        /* 0x29C */ public GcItemPriceModifiers Cost;
        [NMS(Index = 8)]
        /* 0x2B0 */ public int BaseValue;
        [NMS(Index = 13)]
        /* 0x2B4 */ public GcRealitySubstanceCategory Category;
        [NMS(Index = 18)]
        /* 0x2B8 */ public int ChargeValue;
        [NMS(Index = 41)]
        /* 0x2BC */ public float CookingValue;
        [NMS(Index = 22)]
        /* 0x2C0 */ public int CraftAmountMultiplier;
        [NMS(Index = 21)]
        /* 0x2C4 */ public int CraftAmountStepSize;
        [NMS(Index = 20)]
        /* 0x2C8 */ public int DefaultCraftAmount;
        [NMS(Index = 34)]
        /* 0x2CC */ public float EconomyInfluenceMultiplier;
        [NMS(Index = 16)]
        /* 0x2D0 */ public GcLegality Legality;
        [NMS(Index = 9)]
        /* 0x2D4 */ public int Level;
        [NMS(Index = 29)]
        /* 0x2D8 */ public float NormalisedValueOffWorld;
        [NMS(Index = 28)]
        /* 0x2DC */ public float NormalisedValueOnWorld;
        [NMS(Index = 38)]
        /* 0x2E0 */ public GcScannerIconTypes PinObjectiveScannableType;
        [NMS(Index = 15)]
        /* 0x2E4 */ public GcRarity Rarity;
        [NMS(Index = 26)]
        /* 0x2E8 */ public int RecipeCost;
        [NMS(Index = 19)]
        /* 0x2EC */ public int StackMultiplier;
        [NMS(Index = 30)]
        /* 0x2F0 */ public GcTradeCategory TradeCategory;
        [NMS(Index = 14)]
        /* 0x2F4 */ public GcProductCategory Type;
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
        /* 0x2F8 */ public WikiCategoryEnum WikiCategory;
        [NMS(Index = 1)]
        /* 0x2FC */ public NMSString0x80 Name;
        [NMS(Index = 2)]
        /* 0x37C */ public NMSString0x80 NameLower;
        [NMS(Index = 46)]
        /* 0x3FC */ public bool CanSendToOtherPlayers;
        [NMS(Index = 17)]
        /* 0x3FD */ public bool Consumable;
        [NMS(Index = 40)]
        /* 0x3FE */ public bool CookingIngredient;
        [NMS(Index = 44)]
        /* 0x3FF */ public bool EggModifierIngredient;
        [NMS(Index = 42)]
        /* 0x400 */ public bool GoodForSelling;
        [NMS(Index = 32)]
        /* 0x401 */ public bool IsCraftable;
        [NMS(Index = 45)]
        /* 0x402 */ public bool IsTechbox;
        [NMS(Index = 39)]
        /* 0x403 */ public bool PinObjectiveEasyToRefine;
        [NMS(Index = 27)]
        /* 0x404 */ public bool SpecificChargeOnly;
    }
}
