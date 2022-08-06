using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x85FF7C1139E3E41A, NameHash = 0xB1D42EFA923F8574)]
    public class GcSolarSystemLocatorTypes : NMSTemplate
    {
		public enum LocatorTypeEnum { Generic1, Generic2, Generic3, Generic4 }
		public LocatorTypeEnum LocatorType;
    }
}