using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78DC4A7E8F743057, NameHash = 0xF23C1EDE)]
    public class GcInputBinding : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public TkVirtualBinding VirtualBinding;
        [NMS(Index = 0)]
        /* 0x68 */ public GcInputActions Action;
        [NMS(Index = 2)]
        /* 0x6C */ public TkInputAxisEnum Axis;
        [NMS(Index = 1)]
        /* 0x70 */ public TkInputEnum Button;
    }
}
