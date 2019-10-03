using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x47465FFF4364C345, NameHash = 0x5D0FDAEE020A4D6C)]
    public class GcTradingSupplyData : NMSTemplate      // size: 0x28
    {
        public ulong GalacticAddress;
        public float Supply;
        public float Demand;
        [NMS(Size = 0x10)]
        public string Product;
        public ulong Timestamp;
    }
}
