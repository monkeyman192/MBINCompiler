namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE2086B32C63C0768, NameHash = 0x6DC70ADC2461C621)]
    public class TkInputAxisEnum : NMSTemplate
    {
        // size: 0x33
        public enum InputAxisEnum : uint {
            None = 0x0,
            Invalid = 0x0,
            LeftStick = 0x1,
            LeftStickX = 0x2,
            LeftStickY = 0x3,
            RightStick = 0x4,
            RightStickX = 0x5,
            RightStickY = 0x6,
            LeftTrigger = 0x7,
            RightTrigger = 0x8,
            Mouse = 0x9,
            MouseX = 0xA,
            MouseY = 0xB,
            MousePositiveX = 0xC,
            MouseNegativeX = 0xD,
            MousePositiveY = 0xE,
            MouseNegativeY = 0xF,
            MouseWheel = 0x10,
            MouseWheelPositive = 0x11,
            MouseWheelNegative = 0x12,
            Touchpad = 0x13,
            TouchpadX = 0x14,
            TouchpadY = 0x15,
            TouchpadPositiveX = 0x16,
            TouchpadNegativeX = 0x17,
            TouchpadPositiveY = 0x18,
            TouchpadNegativeY = 0x19,
            LeftTouchpad = 0x1A,
            LeftTouchpadX = 0x1B,
            LeftTouchpadY = 0x1C,
            LeftTouchpadPositiveX = 0x1D,
            LeftTouchpadNegativeX = 0x1E,
            LeftTouchpadPositiveY = 0x1F,
            LeftTouchpadNegativeY = 0x20,
            LeftGrip = 0x21,
            RightGrip = 0x22,
            LeftStickPositiveX = 0x23,
            LeftStickNegativeX = 0x24,
            LeftStickPositiveY = 0x25,
            LeftStickNegativeY = 0x26,
            RightStickPositiveX = 0x27,
            RightStickNegativeX = 0x28,
            RightStickPositiveY = 0x29,
            RightStickNegativeY = 0x2A,
            DirectionalPadX = 0x2B,
            DirectionalPadY = 0x2C,
            DirectionalButtonsX = 0x2D,
            DirectionalButtonsY = 0x2E,
            ChordAD = 0x2F,
            FakeLeftStick = 0x30,
            FakeRightStick = 0x31,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InputAxisEnum InputAxis;
    }
}
