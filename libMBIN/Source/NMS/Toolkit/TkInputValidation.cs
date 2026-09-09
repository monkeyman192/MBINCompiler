namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEFAFA0FB3E6AEAC8, NameHash = 0xC2130696)]
    public class TkInputValidation : NMSTemplate
    {
        // size: 0x6
        public enum InputValidationEnum : uint {
            Held,
            Pressed,
            HeldConfirm,
            Released,
            HeldOver,
            Canceled,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InputValidationEnum InputValidation;
    }
}
