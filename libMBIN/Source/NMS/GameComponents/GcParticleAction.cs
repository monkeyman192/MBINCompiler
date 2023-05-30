using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcParticleAction : NMSTemplate
    {
        public NMSString0x10 Effect;
        public NMSString0x20 Joint;
        public bool Exact;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding31;
    }
}
