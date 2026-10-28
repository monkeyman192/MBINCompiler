using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE10A32A761CF2361, NameHash = 0x245A8607)]
    public class GcTradeData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcBarterLoc BarterLoc;
        [NMS(Index = 9)]
        /* 0x260 */ public NMSString0x20A SellButtonSub;
        [NMS(Index = 4)]
        /* 0x280 */ public List<NMSString0x10> AlwaysConsideredBarterProducts;
        [NMS(Index = 0)]
        /* 0x290 */ public List<NMSString0x10> AlwaysPresentProducts;
        [NMS(Index = 1)]
        /* 0x2A0 */ public List<NMSString0x10> AlwaysPresentSubstances;
        [NMS(Index = 19)]
        /* 0x2B0 */ public NMSString0x10 MissionMessageToSendOnSuccess;
        [NMS(Index = 2)]
        /* 0x2C0 */ public List<NMSString0x10> OptionalProducts;
        [NMS(Index = 3)]
        /* 0x2D0 */ public List<NMSString0x10> OptionalSubstances;
        [NMS(Index = 21, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x2E0 */ public int[] MaxAmountOfProductAvailable;
        [NMS(Index = 23, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x2F0 */ public int[] MaxAmountOfSubstanceAvailable;
        [NMS(Index = 25, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x300 */ public int[] MaxExtraSystemProducts;
        [NMS(Index = 20, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x310 */ public int[] MinAmountOfProductAvailable;
        [NMS(Index = 22, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x320 */ public int[] MinAmountOfSubstanceAvailable;
        [NMS(Index = 24, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x330 */ public int[] MinExtraSystemProducts;
        [NMS(Index = 26, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x340 */ public float[] TradeProductsPriceImprovements;
        [NMS(Index = 7)]
        /* 0x350 */ public float BarterItemPreferenceFloor;
        [NMS(Index = 6)]
        /* 0x354 */ public float BarterPriceMultiplier;
        [NMS(Index = 14)]
        /* 0x358 */ public float BuyPriceDecreaseGreenThreshold;
        [NMS(Index = 13)]
        /* 0x35C */ public float BuyPriceIncreaseRedThreshold;
        [NMS(Index = 11)]
        /* 0x360 */ public int MaxItemsForSale;
        [NMS(Index = 10)]
        /* 0x364 */ public int MinItemsForSale;
        [NMS(Index = 12)]
        /* 0x368 */ public float PercentageOfItemsAreProducts;
        [NMS(Index = 16)]
        /* 0x36C */ public float SellPriceDecreaseRedThreshold;
        [NMS(Index = 15)]
        /* 0x370 */ public float SellPriceIncreaseGreenThreshold;
        [NMS(Index = 5)]
        /* 0x374 */ public TkCurveType BarterAcceptanceCurve;
        [NMS(Index = 17)]
        /* 0x375 */ public bool ShowSeasonRewards;
        [NMS(Index = 18)]
        /* 0x376 */ public bool UseBarterForBuy;
    }
}
