namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x19A4B697F70DC366, NameHash = 0xC2130696)]
    public class TkInputValidation : NMSTemplate
    {
        // size: 0x5
        public enum InputValidationEnum : uint {
            Held,
            Pressed,
            HeldConfirm,
            Released,
            HeldOver,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InputValidationEnum InputValidation;
    }
}
