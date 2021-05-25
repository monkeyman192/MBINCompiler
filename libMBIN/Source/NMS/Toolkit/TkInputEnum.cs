using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4, Alignment = 0x4, GUID = 0xBE3D3712B6DF1EB8, NameHash = 0x8C2EDCD50FA3956F)]
    public class TkInputEnum : NMSTemplate
    {
        // size: 0x9B
        public enum InputButtonEnum {
            None = 0x0, Space = 0x20, Exclamation = 0x21, Quotes = 0x22, Hash = 0x23,
            Dollar = 0x24, Percent = 0x25, Ampersand = 0x26, Apostrophe = 0x27, LeftBracket = 0x28,
            RightBracket = 0x29, Asterisk = 0x2A, Plus = 0x2B, Comma = 0x2C, Hyphen = 0x2D,
            Period = 0x2E, Slash = 0x2F, Key0 = 0x30, Key1 = 0x31, Key2 = 0x32,
            Key3 = 0x33, Key4 = 0x34, Key5 = 0x35, Key6 = 0x36, Key7 = 0x37,
            Key8 = 0x38, Key9 = 0x39, Colon = 0x3A, Semicolon = 0x3B, LessThan = 0x3C,
            Equals = 0x3D, GreaterThan = 0x3E, QuestionMark = 0x3F, At = 0x40, KeyA = 0x41,
            KeyB = 0x42, KeyC = 0x43, KeyD = 0x44, KeyE = 0x45, KeyF = 0x46,
            KeyG = 0x47, KeyH = 0x48, KeyI = 0x49, KeyJ = 0x4A, KeyK = 0x4B,
            KeyL = 0x4C, KeyM = 0x4D, KeyN = 0x4E, KeyO = 0x4F, KeyP = 0x50,
            KeyQ = 0x51, KeyR = 0x52, KeyS = 0x53, KeyT = 0x54, KeyU = 0x55,
            KeyV = 0x56, KeyW = 0x57, KeyX = 0x58, KeyY = 0x59, KeyZ = 0x5A,
            LeftSquare = 0x5B, BackSlash = 0x5C, RightSquare = 0x5D, Caret = 0x5E, Underscode = 0x5F,
            Grave = 0x60, LeftCurly = 0x7B, Bar = 0x7C, RightCurly = 0x7D, Tilde = 0x7E,
            Escape = 0x100, Enter = 0x101, Backspace = 0x102, Insert = 0x103, Delete = 0x104,
            Home = 0x105, End = 0x106, PageUp = 0x107, PageDown = 0x108, F1 = 0x109,
            F2 = 0x10A, F3 = 0x10B, F4 = 0x10C, F5 = 0x10D, F6 = 0x10E,
            F7 = 0x10F, F8 = 0x110, F9 = 0x111, F10 = 0x112, F11 = 0x113,
            F12 = 0x114, Tab = 0x115, Shift = 0x116, LShift = 0x117, RShift = 0x118,
            Alt = 0x119, LAlt = 0x11A, RAlt = 0x11B, Ctrl = 0x11C, LCtrl = 0x11D,
            RCtrl = 0x11E, Up = 0x11F, Down = 0x120, Left = 0x121, Right = 0x122,
            KeyboardUnbound = 0x123, Mouse1 = 0x124, Mouse2 = 0x125, Mouse3 = 0x126, Mouse4 = 0x127,
            Mouse5 = 0x128, Mouse6 = 0x129, Mouse7 = 0x12A, Mouse8 = 0x12B, MouseWheelUp = 0x12C,
            MouseWheelDown = 0x12D, MouseUnbound = 0x12E, PadA = 0x12F, PadB = 0x130, PadC = 0x131,
            PadD = 0x132, PadStart = 0x133, PadSelect = 0x134, PadLeftShoulder1 = 0x135, PadRightShoulder1 = 0x136,
            PadLeftShoulder2 = 0x137, PadRightShoulder2 = 0x138, PadLeftTrigger = 0x139, PadRightTrigger = 0x13A, PadLeftThumb = 0x13B,
            PadRightThumb = 0x13C, PadUp = 0x13D, PadDown = 0x13E, PadLeft = 0x13F, PadRight = 0x140,
            PadSpecial1 = 0x141, PadSpecial2 = 0x142, LeftHandA = 0x143, LeftHandB = 0x144, LeftHandC = 0x145,
            LeftHandD = 0x146, ChordBothShoulders = 0x147, PadLeftTriggerSpecial = 0x148, PadRightTriggerSpecial = 0x149, PadUnbound = 0x14A,
            Gesture = 0x14B, GestureLeftWrist = 0x14C, GestureRightWrist = 0x14D, GestureBinoculars = 0x14E, GestureBackpack = 0x14F,
            GestureExitVehicle = 0x150, GestureThrottle = 0x151, GestureFlightStick = 0x152, GestureTeleport = 0x153, MaxEnumValue = 0x154
        };
        public InputButtonEnum InputButton;
    }
}