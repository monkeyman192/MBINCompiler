using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CE08A39CD30FB36, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        /* 0x00 */ public TkVirtualBinding VirtualBinding;
        /* 0x48 */ public GcInputActions Action;
        /* 0x4C */ public TkInputAxisEnum Axis;
        /* 0x50 */ public TkInputEnum Button;
    }
}
