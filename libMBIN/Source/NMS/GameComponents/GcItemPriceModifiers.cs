namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4962C9D2FF04E085, NameHash = 0x4A16D2127CA95139)]
    public class GcItemPriceModifiers : NMSTemplate
    {
        /* 0x00 */ public float BuyBaseMarkup;
        /* 0x04 */ public float BuyMarkupMod;
        /* 0x08 */ public float HighPriceMod;
        /* 0x0C */ public float LowPriceMod;
        /* 0x10 */ public float SpaceStationMarkup;
    }
}
