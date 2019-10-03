using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF4CE658A01F5C02E, NameHash = 0x22715A99B359A960)]
    public class GcSizeIndicator : NMSTemplate
    {
		public enum SizeIndicatorEnum { Small, Medium, Large }
		public SizeIndicatorEnum SizeIndicator;
    }
}
