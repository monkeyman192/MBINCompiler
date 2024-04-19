using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x268CAA7D7CCCB649, NameHash = 0xE831C8A241FD8276)]
    public class GcProductData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour;
        /* 0x010 */ public NMSString0x20A Hint;
        /* 0x030 */ public NMSString0x20A PinObjective;
        /* 0x050 */ public NMSString0x20A PinObjectiveMessage;
        /* 0x070 */ public NMSString0x20A PinObjectiveTip;
        /* 0x090 */ public List<GcTechnologyRequirement> AltRequirements;
        /* 0x0A0 */ public NMSString0x10 DeploysInto;
        /* 0x0B0 */ public VariableSizeString Description;
        /* 0x0C0 */ public NMSString0x10 GiveRewardOnSpecialPurchase;
        /* 0x0D0 */ public NMSString0x10 GroupID;
        /* 0x0E0 */ public NMSString0x10 ID;
        /* 0x0F0 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x100 */ public VariableSizeString Subtitle;
        /* 0x110 */ public TkModelResource DebrisFile;
        /* 0x194 */ public TkTextureResource HeroIcon;
        /* 0x218 */ public TkTextureResource Icon;
        /* 0x29C */ public GcItemPriceModifiers Cost;
        /* 0x2B0 */ public int BaseValue;
        /* 0x2B4 */ public GcRealitySubstanceCategory Category;
        /* 0x2B8 */ public int ChargeValue;
        /* 0x2BC */ public float CookingValue;
        /* 0x2C0 */ public int CraftAmountMultiplier;
        /* 0x2C4 */ public int CraftAmountStepSize;
        /* 0x2C8 */ public int DefaultCraftAmount;
        /* 0x2CC */ public float EconomyInfluenceMultiplier;
        /* 0x2D0 */ public GcLegality Legality;
        /* 0x2D4 */ public int Level;
        /* 0x2D8 */ public float NormalisedValueOffWorld;
        /* 0x2DC */ public float NormalisedValueOnWorld;
        /* 0x2E0 */ public GcScannerIconTypes PinObjectiveScannableType;
        /* 0x2E4 */ public GcRarity Rarity;
        /* 0x2E8 */ public int RecipeCost;
        /* 0x2EC */ public int StackMultiplier;
        /* 0x2F0 */ public GcTradeCategory TradeCategory;
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
        /* 0x2F8 */ public WikiCategoryEnum WikiCategory;
        /* 0x2FC */ public NMSString0x80 Name;
        /* 0x37C */ public NMSString0x80 NameLower;
        /* 0x3FC */ public bool CanSendToOtherPlayers;
        /* 0x3FD */ public bool Consumable;
        /* 0x3FE */ public bool CookingIngredient;
        /* 0x3FF */ public bool EggModifierIngredient;
        /* 0x400 */ public bool GoodForSelling;
        /* 0x401 */ public bool IsCraftable;
        /* 0x402 */ public bool IsTechbox;
        /* 0x403 */ public bool PinObjectiveEasyToRefine;
        /* 0x404 */ public bool SpecificChargeOnly;
    }
}
