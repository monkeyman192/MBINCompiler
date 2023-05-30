using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAsteroidGeneratorSlab : NMSTemplate
    {
        public GcAsteroidGeneratorAssignment Assignment;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding48;

        public Vector4f Rotation;
        public Vector4f Scale;
        public float NoiseOffset;
        public float NoiseScale;
        public float NoiseApply;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding7C;
    }
}
