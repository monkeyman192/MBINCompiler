using System.Collections.Generic;

/// <summary>
/// This struct doesn't seem to be in the exe!!!?
/// It has been constructed by looking at the mbin and piecing it together with other structs...
/// HG what you doing?!
/// </summary>
namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3D0)]
    public class GcProceduralProductData_REALITY : NMSTemplate
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
        /* 0x270 */ public Colour Colour;
        /* 0x280 */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x284 */ public GcProductCategory Type;      // I think??
        /* 0x288 */ public GcProceduralProductCategory ProceduralType;
        /* 0x28C */ public GcRarity Rarity;
        /* 0x290 */ public GcLegality Legality;
        /* 0x294 */ public bool Consumable;
        /* 0x298 */ public int ChargeValue;
        /* 0x29C */ public int StackMultiplier;     // or maybe just padding??
        /* 0x2A0 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x2B0 */ public List<GcTechnologyRequirement> AltRequirements;
        /* 0x2C0 */ public GcItemPriceModifiers Cost;
        /* 0x2D4 */ public bool SpecificChargeOnly;
        /* 0x2D8 */ public float NormalisedValueOnWorld;
        /* 0x2DC */ public float NormalisedValueOffWorld;
        /* 0x2E0 */ public GcTradeCategory TradeCategory;
        /* 0x2E4 */ public bool WikiEnabled;
        /* 0x2E5 */ public bool IsCraftable;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2E6 */ public byte[] Padding2E6;
        /* 0x2E8 */ public float EconomyInfluenceMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2EC */ public byte[] Padding2EC;
        
        [NMS(Size = 0x3)]
        /* 0x2F0 */ public GcProductProceduralOnlyData[] ProceduralData;

        /* 0x398 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3CC */ public byte[] EndPadding;
    }
}
