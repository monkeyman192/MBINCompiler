using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDBC5A035A3C5D89D, NameHash = 0x3C7F32FAD34D5752)]
    public class GcOutpostLSystemPair : NMSTemplate // 0x320 bytes
    {
        [NMS(Size = 0x20)]
        public string Locator;
        [NMS(Size = 7)]
        public NMSString0x80[] LSystems;
    }
}
