using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8AF7F1C3674147C5, NameHash = 0xE8931C5D607657DE)]
    public class GcDay : NMSTemplate
    {
		public enum DayEnum { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
		public DayEnum Day;
    }
}
