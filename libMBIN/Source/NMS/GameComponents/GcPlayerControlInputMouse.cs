using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3AF19583EA8310D, NameHash = 0xAD69A6B3)]
    public class GcPlayerControlInputMouse : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 Output;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 OutputLength;
        // size: 0x1
        public enum InputMouseModeEnum : uint {
            ScreenCentrePos,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public InputMouseModeEnum InputMouseMode;
        [NMS(Index = 2)]
        /* 0x24 */ public GcCharacterControlOutputSpace OutputSpace;
        [NMS(Index = 0)]
        /* 0x28 */ public GcCharacterControlInputValidity Validity;
    }
}
