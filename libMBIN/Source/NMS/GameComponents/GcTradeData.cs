using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB29F8A0A5C974FCF, NameHash = 0x245A8607)]
    public class GcTradeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> AlwaysPresentProducts;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> AlwaysPresentSubstances;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> OptionalProducts;
        [NMS(Index = 3)]
        /* 0x30 */ public List<NMSString0x10> OptionalSubstances;
        [NMS(Index = 13, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x40 */ public int[] MaxAmountOfProductAvailable;
        [NMS(Index = 15, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x50 */ public int[] MaxAmountOfSubstanceAvailable;
        [NMS(Index = 17, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x60 */ public int[] MaxExtraSystemProducts;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x70 */ public int[] MinAmountOfProductAvailable;
        [NMS(Index = 14, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x80 */ public int[] MinAmountOfSubstanceAvailable;
        [NMS(Index = 16, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x90 */ public int[] MinExtraSystemProducts;
        [NMS(Index = 18, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0xA0 */ public float[] TradeProductsPriceImprovements;
        [NMS(Index = 8)]
        /* 0xB0 */ public float BuyPriceDecreaseGreenThreshold;
        [NMS(Index = 7)]
        /* 0xB4 */ public float BuyPriceIncreaseRedThreshold;
        [NMS(Index = 5)]
        /* 0xB8 */ public int MaxItemsForSale;
        [NMS(Index = 4)]
        /* 0xBC */ public int MinItemsForSale;
        [NMS(Index = 6)]
        /* 0xC0 */ public float PercentageOfItemsAreProducts;
        [NMS(Index = 10)]
        /* 0xC4 */ public float SellPriceDecreaseRedThreshold;
        [NMS(Index = 9)]
        /* 0xC8 */ public float SellPriceIncreaseGreenThreshold;
        [NMS(Index = 11)]
        /* 0xCC */ public bool ShowSeasonRewards;
    }
}
