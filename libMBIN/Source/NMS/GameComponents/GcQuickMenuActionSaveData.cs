using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA9C5102B4856DE0, NameHash = 0x61887D42)]
    public class GcQuickMenuActionSaveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public GcInventoryIndex InventoryIndex;
        [NMS(Index = 0)]
        /* 0x18 */ public GcQuickMenuActions Action;
        [NMS(Index = 2)]
        /* 0x1C */ public int Number;
    }
}
