namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2E2C674D8D2E799, NameHash = 0xAEC62A33)]
    public class GcTradingSupplyData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong GalacticAddress;
        [NMS(Index = 4)]
        /* 0x18 */ public ulong Timestamp;
        [NMS(Index = 2)]
        /* 0x20 */ public float Demand;
        [NMS(Index = 1)]
        /* 0x24 */ public float Supply;
    }
}
