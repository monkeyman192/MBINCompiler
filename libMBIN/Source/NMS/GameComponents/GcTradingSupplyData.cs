namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6102D55E9E0BE76A, NameHash = 0x5D0FDAEE020A4D6C)]
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
