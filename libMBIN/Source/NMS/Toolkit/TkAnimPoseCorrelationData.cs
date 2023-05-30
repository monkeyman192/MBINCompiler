using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAnimPoseCorrelationData : NMSTemplate // 0x28 bytes
    {
        public NMSString0x10 ItemA;
        public NMSString0x10 ItemB;
        public float Correlation;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
    }
}
