using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCDD1753E3C085C69, NameHash = 0x2FCEFF0AE05742C0)]
    public class GcHazardAction : NMSTemplate
    {
        public GcHazardModifiers Hazard;
        public float Strength;
        public float Radius;
        public bool RadiusBasedStrength;
    }
}
