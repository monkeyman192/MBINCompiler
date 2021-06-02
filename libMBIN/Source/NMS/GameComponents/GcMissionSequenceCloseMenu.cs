using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x5CF50411F86F56C9, NameHash = 0xE62B86A237CB0756)]
    public class GcMissionSequenceCloseMenu : NMSTemplate
    {
        public float Delay;
        public enum MenuToCloseEnum { QuickMenu, BuildMenu, Inventory, AllDetailMessages }
        public MenuToCloseEnum MenuToClose;
        public NMSString0x80 DebugText;
    }
}
