using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x30093440ED31F004, NameHash = 0x737DC36BC0894840)]
    public class GcGalaxyStarTypes : NMSTemplate
    {
		public enum GalaxyStarTypeEnum { Yellow, Green, Blue, Red }
		public GalaxyStarTypeEnum GalaxyStarType;
    }
}
