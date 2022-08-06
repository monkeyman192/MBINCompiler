using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9755EFA88663FD0B, NameHash = 0x1A9351C5A8C07BA4)]
    public class GcCharacterControlInputValidity : NMSTemplate
    {
        // size: 0x3
        // Note: in the exe the 3rd value has a typo: "KeyboardAnMouseOnly"
        public enum CharacterControlInputValidityEnum { Always, PadOnly, KeyboardAndMouseOnly }
        public CharacterControlInputValidityEnum CharacterControlInputValidity;
    }
}
