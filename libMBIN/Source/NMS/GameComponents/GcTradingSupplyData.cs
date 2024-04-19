namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6102D55E9E0BE76A, NameHash = 0x5D0FDAEE020A4D6C)]
    public class GcTradingSupplyData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Product;
        /* 0x10 */ public ulong GalacticAddress;
        /* 0x18 */ public ulong Timestamp;
        /* 0x20 */ public float Demand;
        /* 0x24 */ public float Supply;
    }
}
