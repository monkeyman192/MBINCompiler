namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBA66DB1C5C67A3C0, NameHash = 0xB4C05EB8)]
    public class TkPadEnum : NMSTemplate
    {
        // size: 0x11
        public enum PadEnum : uint {
            None,
            XInput,
            GLFW,
            XBoxOne,
            XBox360,
            DS4,
            DS5,
            Move,
            SteamInput,
            Touch,
            OpenVR,
            SwitchPro,
            SwitchHandheld,
            GameInput,
            SwitchDebugPad,
            SwitchJoyConDual,
            VirtualController,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PadEnum Pad;
    }
}
