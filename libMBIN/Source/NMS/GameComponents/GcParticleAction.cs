using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC66F2BC309F54332, NameHash = 0x88C11D6208F25864)]
    public class GcParticleAction : NMSTemplate
    {
        public NMSString0x10 Effect;
        public NMSString0x20 Joint;
        public bool Exact;
        public GcBroadcastLevel FindRange;
    }
}
