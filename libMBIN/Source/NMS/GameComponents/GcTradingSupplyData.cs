using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47465FFF4364C345, NameHash = 0x5D0FDAEE020A4D6C)]
    public class GcTradingSupplyData : NMSTemplate
    {
        /* 0x00 */ public ulong GalacticAddress;
        /* 0x08 */ public float Supply;
        /* 0x0C */ public float Demand;
        /* 0x10 */ public NMSString0x10 Product;
        /* 0x20 */ public ulong Timestamp;
    }
}
