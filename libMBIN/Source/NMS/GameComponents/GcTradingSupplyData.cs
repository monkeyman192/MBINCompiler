using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x47465FFF4364C345, NameHash = 0x5D0FDAEE020A4D6C)]
    public class GcTradingSupplyData : NMSTemplate      // size: 0x28
    {
        public ulong GalacticAddress;
        public float Supply;
        public float Demand;
        public NMSString0x10 Product;
        public ulong Timestamp;
    }
}