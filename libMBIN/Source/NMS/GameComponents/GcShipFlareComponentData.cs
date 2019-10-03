using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1E6DFC2F6689E5A4, NameHash = 0xCF633C20574F7F38)]
    public class GcShipFlareComponentData : NMSTemplate
    {
		public enum FlareTypeEnum { Default }
		public FlareTypeEnum FlareType;
    }
}
