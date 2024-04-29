namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C930735CA98081E, NameHash = 0x4A16D2127CA95139)]
    public class GcItemPriceModifiers : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float BuyBaseMarkup;
        [NMS(Index = 4)]
        /* 0x04 */ public float BuyMarkupMod;
        [NMS(Index = 2)]
        /* 0x08 */ public float HighPriceMod;
        [NMS(Index = 1)]
        /* 0x0C */ public float LowPriceMod;
        [NMS(Index = 0)]
        /* 0x10 */ public float SpaceStationMarkup;
    }
}
