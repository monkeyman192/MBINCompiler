using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5AC84A35CBFF4798, NameHash = 0xC66C80C1B41A77FD)]
    public class GcSolarSystemClass : NMSTemplate
    {
		public enum SolarSystemClassEnum { Default, Initial, Anomaly, GameStart }
		public SolarSystemClassEnum SolarSystemClass;
    }
}