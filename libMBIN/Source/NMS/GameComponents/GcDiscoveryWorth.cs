using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7C02623F66277A41, NameHash = 0xC9D7FFE72FBDED51)]
    public class GcDiscoveryWorth : NMSTemplate     // size: 0x1C
    {
        [NMS(Size = 0x3)]
        public int[] Record;
        [NMS(Size = 0x3)]
        public int[] OnScan;
        public int Mission;
    }
}
