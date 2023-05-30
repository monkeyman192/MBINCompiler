using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkRotationComponentData : NMSTemplate
    {
        public float Speed;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Axis;
    }
}
