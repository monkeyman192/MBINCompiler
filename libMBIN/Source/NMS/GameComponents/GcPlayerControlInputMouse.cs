using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x680E1192FFA80143, NameHash = 0x8CC79014E9CB899E)]
    public class GcPlayerControlInputMouse : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Output;
        /* 0x10 */ public NMSString0x10 OutputLength;
        // size: 0x1
        public enum InputMouseModeEnum : uint {
            ScreenCentrePos,
        }
        /* 0x20 */ public InputMouseModeEnum InputMouseMode;
        /* 0x24 */ public GcCharacterControlOutputSpace OutputSpace;
        /* 0x28 */ public GcCharacterControlInputValidity Validity;
    }
}
