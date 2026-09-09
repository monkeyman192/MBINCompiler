using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE82FE1E0B8C2C3FB, NameHash = 0x77C00C01)]
    public class GcRealitySubstanceData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 9)]
        /* 0x010 */ public Colour WorldColour;
        [NMS(Index = 5)]
        /* 0x020 */ public TkModelResource DebrisFile;
        [NMS(Index = 22)]
        /* 0x040 */ public NMSString0x20A PinObjective;
        [NMS(Index = 24)]
        /* 0x060 */ public NMSString0x20A PinObjectiveMessage;
        [NMS(Index = 23)]
        /* 0x080 */ public NMSString0x20A PinObjectiveTip;
        [NMS(Index = 4)]
        /* 0x0A0 */ public TkTextureResource Icon;
        [NMS(Index = 7)]
        /* 0x0B8 */ public VariableSizeString Description;
        [NMS(Index = 2)]
        /* 0x0C8 */ public NMSString0x10 ID;
        [NMS(Index = 6)]
        /* 0x0D8 */ public VariableSizeString Subtitle;
        [NMS(Index = 26)]
        /* 0x0E8 */ public NMSString0x10 WikiMissionID;
        [NMS(Index = 16)]
        /* 0x0F8 */ public GcItemPriceModifiers Cost;
        [NMS(Index = 10)]
        /* 0x10C */ public int BaseValue;
        [NMS(Index = 11)]
        /* 0x110 */ public GcRealitySubstanceCategory Category;
        [NMS(Index = 14)]
        /* 0x114 */ public int ChargeValue;
        [NMS(Index = 21)]
        /* 0x118 */ public float EconomyInfluenceMultiplier;
        [NMS(Index = 13)]
        /* 0x11C */ public GcLegality Legality;
        [NMS(Index = 18)]
        /* 0x120 */ public float NormalisedValueOffWorld;
        [NMS(Index = 17)]
        /* 0x124 */ public float NormalisedValueOnWorld;
        [NMS(Index = 12)]
        /* 0x128 */ public GcRarity Rarity;
        [NMS(Index = 15)]
        /* 0x12C */ public int StackMultiplier;
        [NMS(Index = 19)]
        /* 0x130 */ public GcTradeCategory TradeCategory;
        [NMS(Index = 0)]
        /* 0x134 */ public NMSString0x20 Name;
        [NMS(Index = 1)]
        /* 0x154 */ public NMSString0x20 NameLower;
        [NMS(Index = 3)]
        /* 0x174 */ public NMSString0x20 Symbol;
        [NMS(Index = 28)]
        /* 0x194 */ public bool CookingIngredient;
        [NMS(Index = 30)]
        /* 0x195 */ public bool EasyToRefine;
        [NMS(Index = 31)]
        /* 0x196 */ public bool EggModifierIngredient;
        [NMS(Index = 29)]
        /* 0x197 */ public bool GoodForSelling;
        [NMS(Index = 27)]
        /* 0x198 */ public bool OnlyFoundInPurpleSytems;
        [NMS(Index = 25)]
        /* 0x199 */ public GcScannerIconTypes PinObjectiveScannableType;
        [NMS(Index = 20)]
        /* 0x19A */ public bool WikiEnabled;
    }
}
