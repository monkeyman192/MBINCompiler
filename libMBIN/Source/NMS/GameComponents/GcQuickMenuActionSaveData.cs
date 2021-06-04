using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x77AC48B35CFBA776, NameHash = 0x15BEBD4BD6DD1244)]
    public class GcQuickMenuActionSaveData : NMSTemplate
    {
        /* 0x00 */ public GcQuickMenuActions Action;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Number;
        /* 0x1C */ public GcInventoryIndex InventoryIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
