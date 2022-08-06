using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x32F57E5DE98FD32, NameHash = 0xE46F247D87F34DBC)]
    public class GcProceduralTechnologyCategory : NMSTemplate
    {
		public enum ProceduralTechnologyCategoryEnum { None, Combat, Mining, Scanning, Protection }
		public ProceduralTechnologyCategoryEnum ProceduralTechnologyCategory;
    }
}