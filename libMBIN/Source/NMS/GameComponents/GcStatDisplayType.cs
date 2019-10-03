using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF373CC74C47A4AF, NameHash = 0x7E6B18F25C0843D4)]
    public class GcStatDisplayType : NMSTemplate
    {
		public enum StatDisplayTypeEnum { None, Sols, Distance }
		public StatDisplayTypeEnum StatDisplayType;
    }
}
