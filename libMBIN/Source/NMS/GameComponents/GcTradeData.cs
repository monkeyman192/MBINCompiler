using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6788A16C7C9B141A, NameHash = 0x66FAEFAF4E8E7167)]
    public class GcTradeData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AlwaysPresentProducts;
        /* 0x10 */ public List<NMSString0x10> AlwaysPresentSubstances;
        /* 0x20 */ public List<NMSString0x10> OptionalProducts;
        /* 0x30 */ public List<NMSString0x10> OptionalSubstances;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x40 */ public int[] MaxAmountOfProductAvailable;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x50 */ public int[] MaxAmountOfSubstanceAvailable;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x60 */ public int[] MaxExtraSystemProducts;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x70 */ public int[] MinAmountOfProductAvailable;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x80 */ public int[] MinAmountOfSubstanceAvailable;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x90 */ public int[] MinExtraSystemProducts;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0xA0 */ public float[] TradeProductsPriceImprovements;
        /* 0xB0 */ public float BuyPriceDecreaseGreenThreshold;
        /* 0xB4 */ public float BuyPriceIncreaseRedThreshold;
        /* 0xB8 */ public int MaxItemsForSale;
        /* 0xBC */ public int MinItemsForSale;
        /* 0xC0 */ public float PercentageOfItemsAreProducts;
        /* 0xC4 */ public float SellPriceDecreaseRedThreshold;
        /* 0xC8 */ public float SellPriceIncreaseGreenThreshold;
        /* 0xCC */ public bool ShowSeasonRewards;
    }
}
