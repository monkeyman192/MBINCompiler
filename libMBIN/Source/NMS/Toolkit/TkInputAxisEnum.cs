using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3AAEF54B3BF203E, NameHash = 0x6DC70ADC2461C621)]
    public class TkInputAxisEnum : NMSTemplate
    {
        // In the exe there is both a None and an Invalid entry, but both have the enum value of 0x0, which we can't really handle so I'll just ignore the "None" value...
        // size: 0x30
        public enum InputAxisEnum {
            Invalid, LeftStick, LeftStickX, LeftStickY, RightStick, RightStickX, RightStickY, LeftTrigger, RightTrigger,
            Mouse, MouseX, MouseY, MousePositiveX, MouseNegativeX, MousePositiveY, MouseNegativeY, MouseWheel, MouseWheelPositive, MouseWheelNegative,
            Touchpad, TouchpadX, TouchpadY, TouchpadPositiveX, TouchpadNegativeX, TouchpadPositiveY, TouchpadNegativeY, LeftTouchpad, LeftTouchpadX, LeftTouchpadY,
            LeftTouchpadPositiveX, LeftTouchpadNegativeX, LeftTouchpadPositiveY, LeftTouchpadNegativeY, LeftGrip, RightGrip, LeftStickPositiveX, LeftStickNegativeX, LeftStickPositiveY, LeftStickNegativeY,
            RightStickPositiveX, RightStickNegativeX, RightStickPositiveY, RightStickNegativeY, DirectionalPadX, DirectionalPadY, DirectionalButtonsX, DirectionalButtonsY, ChordAD
        }
        public InputAxisEnum InputAxis;
    }
}