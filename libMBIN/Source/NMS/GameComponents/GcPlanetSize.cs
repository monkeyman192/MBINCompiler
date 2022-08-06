using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x54E73B4E8FC596F5, NameHash = 0xE198F55796BC6E2F)]
    public class GcPlanetSize : NMSTemplate
    {
		public enum PlanetSizeEnum { Large, Medium, Small, Moon }
		public PlanetSizeEnum PlanetSize;
    }
}