namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1ACA35E74A19273, NameHash = 0xE62B86A237CB0756)]
    public class GcMissionSequenceCloseMenu : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Delay;
        // size: 0x4
        public enum MenuToCloseEnum : uint {
            QuickMenu,
            BuildMenu,
            Inventory,
            AllDetailMessages,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public MenuToCloseEnum MenuToClose;
        [NMS(Index = 2)]
        /* 0x8 */ public NMSString0x80 DebugText;
    }
}
