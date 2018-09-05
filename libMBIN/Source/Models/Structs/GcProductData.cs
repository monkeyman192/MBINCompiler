using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3E0)]
    public class GcProductData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string NameLower;
        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        [NMS(Size = 0x20)]
        /* 0x130 */ public string Hint;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string GroupID;
        /* 0x160 */ public TkModelResource DebrisFile;
        /* 0x1E4 */ public int BaseValue;
        /* 0x1E8 */ public int Level;
        /* 0x1EC */ public TkModelResource Icon;
        /* 0x270 */ public TkModelResource HeroIcon;
        /* 0x300 */ public Colour Colour;
        /* 0x310 */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x314 */ public GcProductCategory Type;      // I think??
        /* 0x318 */ public GcProceduralProductCategory ProceduralType;
        /* 0x31C */ public GcRarity Rarity;
        /* 0x320 */ public GcLegality Legality;
        /* 0x324 */ public bool Consumable;
        /* 0x328 */ public int ChargeValue;
        /* 0x32C */ public int StackMultiplier;
        /* 0x330 */ public int DefaultCraftAmount;
        /* 0x334 */ public int CraftAmountStepSize;
        /* 0x338 */ public int CraftAmountMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x33C */ public byte[] Padding33C;
        /* 0x340 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x350 */ public List<GcTechnologyRequirement> AltRequirements;
        /* 0x360 */ public GcItemPriceModifiers Cost;
        /* 0x374 */ public bool SpecificChargeOnly;
        /* 0x378 */ public float NormalisedValueOnWorld;
        /* 0x37C */ public float NormalisedValueOffWorld;
        /* 0x380 */ public GcTradeCategory TradeCategory;
        /* 0x384 */ public bool WikiEnabled;
        /* 0x385 */ public bool IsCraftable;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x386 */ public byte[] Padding386;
        [NMS(Size = 0x10)]
        /* 0x388 */ public string DeploysInto;
        /* 0x398 */ public float EconomyInfluenceMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x39C */ public byte[] Padding39C;
        [NMS(Size = 0x20)]
        /* 0x3A0 */ public string PinObjeective;
        [NMS(Size = 0x20)]
        /* 0x3C0 */ public string PinObjeectiveTip;
    }
}
