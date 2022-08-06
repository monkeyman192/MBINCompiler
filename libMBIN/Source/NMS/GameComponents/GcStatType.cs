using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC5B5E7E09FF7A701, NameHash = 0xC9590B318F3C4D2)]
    public class GcStatType : NMSTemplate
    {
		public enum StatTypeEnum { Int, Float, AvgRate }
		public StatTypeEnum StatType;
    }
}