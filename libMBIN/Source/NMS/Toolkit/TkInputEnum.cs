using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkInputEnum : NMSTemplate
    {
        public int InputButton;
        public string[] InputButtonValuesTODO() // todo: these need to be shifted +0x100, fix this once we can [de]serialize enums!
        {
            return new[] { "None", "Esc", "Enter", "Backspace", "Del", "Home", "End", "PageUp", "PageDown", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12",
			"Tab", "LShift", "RShift", "LAlt", "RAlt", "LCtrl", "RCtrl", "Up", "Down", "Left", "Right", "PadA", "PadB", "PadC", "PadD", "PadStart", "PadSelect", "PadLeftShoulder1",
			"PadRightShoulder1", "PadLeftShoulder2", "PadRightShoulder2", "PadLeftTrigger", "PadRightTrigger", "PadLeftThumb", "PadRightThumb", "PadUp", "PadDown", "PadLeft", "PadRight",
			"Mouse1", "Mouse2", "Mouse3", "Mouse4", "Mouse5", "Mouse6", "Mouse7", "Mouse8" };
        }
    }
}
