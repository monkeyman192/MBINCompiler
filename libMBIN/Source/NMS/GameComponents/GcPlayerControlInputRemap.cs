using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68B164F921EC075F, NameHash = 0x907551D5CDAAAA41)]
    public class GcPlayerControlInputRemap : NMSTemplate
    {
        /* 0x0 */ public GcInputActions Action;
        /* 0x4 */ public GcInputActions CanBeTriggeredBy;
        // size: 0x2
        public enum InputRemapModeEnum : uint {
            ReplaceOriginalBinding,
            AdditionalBinding,
        }
        /* 0x8 */ public InputRemapModeEnum InputRemapMode;
        /* 0xC */ public GcCharacterControlInputValidity Validity;
    }
}
