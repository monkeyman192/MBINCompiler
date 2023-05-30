using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSpawnComponentOption : NMSTemplate // 0x2C8 bytes
    {
        public NMSString0x10 Name;
        public GcSeed Seed;
        public GcResourceElement SpecificModel;
    }
}
