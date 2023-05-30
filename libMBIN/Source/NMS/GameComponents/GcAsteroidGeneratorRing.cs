using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAsteroidGeneratorRing : NMSTemplate
    {
        public GcAsteroidGeneratorAssignment Assignment;
        public float LowerRadius;
        public float UpperRadius;
        public float PushRadius;
        public int OffBalance;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding58;

        public Vector4f Rotation;
        public float USpread;
        public float PushAmount;
        public bool FlipPush;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding79;
    }
}
