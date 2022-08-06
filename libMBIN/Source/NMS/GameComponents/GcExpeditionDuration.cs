using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2581475059916919, NameHash = 0x406EA68C88F85056)]
    public class GcExpeditionDuration : NMSTemplate
    {
		public enum ExpeditionDurationEnum { VeryShort, Short, Medium, Long, VeryLong }
		public ExpeditionDurationEnum ExpeditionDuration;
    }
}