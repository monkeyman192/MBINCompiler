namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8B660522335BA0A8, NameHash = 0xC2130696)]
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
