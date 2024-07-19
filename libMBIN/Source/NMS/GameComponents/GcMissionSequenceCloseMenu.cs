namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24F098D345F57C65, NameHash = 0xC8C9F116)]
    public class GcMissionSequenceCloseMenu : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public float Delay;
        // size: 0x4
        public enum MenuToCloseEnum : uint {
            QuickMenu,
            BuildMenu,
            Inventory,
            AllDetailMessages,
        }
        [NMS(Index = 1)]
        /* 0x14 */ public MenuToCloseEnum MenuToClose;
    }
}
