using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xA88A842C4F72436, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        public GcInputActions Action;
        public TkInputEnum Button;
        public TkInputAxisEnum Axis;
    }
}
