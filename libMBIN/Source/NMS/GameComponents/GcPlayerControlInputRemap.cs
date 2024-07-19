using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C316C5E46E932CA, NameHash = 0xA91801E2)]
    public class GcPlayerControlInputRemap : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInputActions Action;
        [NMS(Index = 2)]
        /* 0x4 */ public GcInputActions CanBeTriggeredBy;
        // size: 0x2
        public enum InputRemapModeEnum : uint {
            ReplaceOriginalBinding,
            AdditionalBinding,
        }
        [NMS(Index = 3)]
        /* 0x8 */ public InputRemapModeEnum InputRemapMode;
        [NMS(Index = 0)]
        /* 0xC */ public GcCharacterControlInputValidity Validity;
    }
}
