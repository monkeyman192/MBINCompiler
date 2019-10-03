using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x59FDEDC6EC119BDF, NameHash = 0xDF042CD9CF0C561)]
    public class GcFiendCrimeAction : NMSTemplate
    {
        public GcFiendCrime FiendCrimeType;
        public float FiendCrimeModifier;
    }
}
