using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9B379844F50F9B9A, NameHash = 0x3DB976BCF84F474B)]
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Size = 5)]
        public float[] Temperature;

        [NMS(Size = 5)]
        public float[] Toxicity;

        [NMS(Size = 5)]
        public float[] Radiation;

        [NMS(Size = 5)]
        public float[] LifeSupportDrain;
    }
}
