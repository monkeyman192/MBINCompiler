using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcOutpostLSystemPair : NMSTemplate // 0x320 bytes
    {
        public NMSString0x20 Locator;
        [NMS(Size = 6)]
        public NMSString0x80[] LSystems;
    }
}
