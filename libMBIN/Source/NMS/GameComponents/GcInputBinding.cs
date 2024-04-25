using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CE08A39CD30FB36, NameHash = 0x4A8D0B35C3429A12)]
    public class GcInputBinding : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public TkVirtualBinding VirtualBinding;
        [NMS(Index = 0)]
        /* 0x48 */ public GcInputActions Action;
        [NMS(Index = 2)]
        /* 0x4C */ public TkInputAxisEnum Axis;
        [NMS(Index = 1)]
        /* 0x50 */ public TkInputEnum Button;
    }
}
