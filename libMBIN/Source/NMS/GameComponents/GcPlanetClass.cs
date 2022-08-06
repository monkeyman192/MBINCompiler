using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x853259960926BF67, NameHash = 0x9EB26F87ECDE68DC)]
    public class GcPlanetClass : NMSTemplate
    {
		public enum PlanetClassEnum { Default, Initial, InInitialSystem }
		public PlanetClassEnum PlanetClass;
    }
}