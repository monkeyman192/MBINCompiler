using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x64987573D6129EB5, NameHash = 0xA7C99AD4BD0E24FB)]
    public class GcResourceOrigin : NMSTemplate
    {
		public enum ResourceOriginEnum { Terrain, Crystal, Asteroid, Robot, Depot }
		public ResourceOriginEnum ResourceOrigin;
    }
}