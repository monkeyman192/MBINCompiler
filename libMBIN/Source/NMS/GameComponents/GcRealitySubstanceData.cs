using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x241F3A24C8346F91, NameHash = 0xD811F4C9E014843E)]
    public class GcRealitySubstanceData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour;
        /* 0x010 */ public Colour WorldColour;
        /* 0x020 */ public NMSString0x20A PinObjective;
        /* 0x040 */ public NMSString0x20A PinObjectiveMessage;
        /* 0x060 */ public NMSString0x20A PinObjectiveTip;
        /* 0x080 */ public VariableSizeString Description;
        /* 0x090 */ public NMSString0x10 ID;
        /* 0x0A0 */ public VariableSizeString Subtitle;
        /* 0x0B0 */ public NMSString0x10 WikiMissionID;
        /* 0x0C0 */ public TkModelResource DebrisFile;
        /* 0x144 */ public TkTextureResource Icon;
        /* 0x1C8 */ public GcItemPriceModifiers Cost;
        /* 0x1DC */ public int BaseValue;
        /* 0x1E0 */ public GcRealitySubstanceCategory Category;
        /* 0x1E4 */ public int ChargeValue;
        /* 0x1E8 */ public float EconomyInfluenceMultiplier;
        /* 0x1EC */ public GcLegality Legality;
        /* 0x1F0 */ public float NormalisedValueOffWorld;
        /* 0x1F4 */ public float NormalisedValueOnWorld;
        /* 0x1F8 */ public GcScannerIconTypes PinObjectiveScannableType;
        /* 0x1FC */ public GcRarity Rarity;
        /* 0x200 */ public int StackMultiplier;
        /* 0x204 */ public GcTradeCategory TradeCategory;
        /* 0x208 */ public NMSString0x20 Name;
        /* 0x228 */ public NMSString0x20 NameLower;
        /* 0x248 */ public NMSString0x20 Symbol;
        /* 0x268 */ public bool CookingIngredient;
        /* 0x269 */ public bool EasyToRefine;
        /* 0x26A */ public bool EggModifierIngredient;
        /* 0x26B */ public bool GoodForSelling;
        /* 0x26C */ public bool WikiEnabled;
    }
}
