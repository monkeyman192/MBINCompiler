using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E8A798F3C681425, NameHash = 0xD811F4C9E014843E)]
    public class GcRealitySubstanceData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 9)]
        /* 0x010 */ public Colour WorldColour;
        [NMS(Index = 22)]
        /* 0x020 */ public NMSString0x20A PinObjective;
        [NMS(Index = 24)]
        /* 0x040 */ public NMSString0x20A PinObjectiveMessage;
        [NMS(Index = 23)]
        /* 0x060 */ public NMSString0x20A PinObjectiveTip;
        [NMS(Index = 7)]
        /* 0x080 */ public VariableSizeString Description;
        [NMS(Index = 2)]
        /* 0x090 */ public NMSString0x10 ID;
        [NMS(Index = 6)]
        /* 0x0A0 */ public VariableSizeString Subtitle;
        [NMS(Index = 26)]
        /* 0x0B0 */ public NMSString0x10 WikiMissionID;
        [NMS(Index = 5)]
        /* 0x0C0 */ public TkModelResource DebrisFile;
        [NMS(Index = 4)]
        /* 0x144 */ public TkTextureResource Icon;
        [NMS(Index = 16)]
        /* 0x1C8 */ public GcItemPriceModifiers Cost;
        [NMS(Index = 10)]
        /* 0x1DC */ public int BaseValue;
        [NMS(Index = 11)]
        /* 0x1E0 */ public GcRealitySubstanceCategory Category;
        [NMS(Index = 14)]
        /* 0x1E4 */ public int ChargeValue;
        [NMS(Index = 21)]
        /* 0x1E8 */ public float EconomyInfluenceMultiplier;
        [NMS(Index = 13)]
        /* 0x1EC */ public GcLegality Legality;
        [NMS(Index = 18)]
        /* 0x1F0 */ public float NormalisedValueOffWorld;
        [NMS(Index = 17)]
        /* 0x1F4 */ public float NormalisedValueOnWorld;
        [NMS(Index = 25)]
        /* 0x1F8 */ public GcScannerIconTypes PinObjectiveScannableType;
        [NMS(Index = 12)]
        /* 0x1FC */ public GcRarity Rarity;
        [NMS(Index = 15)]
        /* 0x200 */ public int StackMultiplier;
        [NMS(Index = 19)]
        /* 0x204 */ public GcTradeCategory TradeCategory;
        [NMS(Index = 0)]
        /* 0x208 */ public NMSString0x20 Name;
        [NMS(Index = 1)]
        /* 0x228 */ public NMSString0x20 NameLower;
        [NMS(Index = 3)]
        /* 0x248 */ public NMSString0x20 Symbol;
        [NMS(Index = 27)]
        /* 0x268 */ public bool CookingIngredient;
        [NMS(Index = 29)]
        /* 0x269 */ public bool EasyToRefine;
        [NMS(Index = 30)]
        /* 0x26A */ public bool EggModifierIngredient;
        [NMS(Index = 28)]
        /* 0x26B */ public bool GoodForSelling;
        [NMS(Index = 20)]
        /* 0x26C */ public bool WikiEnabled;
    }
}
