namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80368A509B1B150A, NameHash = 0x17AE5B83C6E9DF12)]
    public class GcCurrency : NMSTemplate
    {
        // size: 0x3
        public enum CurrencyEnum : uint {
            Units,
            Nanites,
            Specials,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CurrencyEnum Currency;
    }
}
