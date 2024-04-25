using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68B164F921EC075F, NameHash = 0x907551D5CDAAAA41)]
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
