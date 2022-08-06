using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1E581C1C2C438049, NameHash = 0xA7877CF3CA740744)]
    public class GcAsteroidGeneratorSlab : NMSTemplate
    {
        public GcAsteroidGeneratorAssignment Assignment;

        public Vector3f Rotation;
        public Vector3f Scale;
        public float NoiseOffset;
        public float NoiseScale;
        public float NoiseApply;
    }
}