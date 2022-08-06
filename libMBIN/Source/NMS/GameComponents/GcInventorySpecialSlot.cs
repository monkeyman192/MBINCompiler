using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7172C7AE26B7A70A, NameHash = 0xB2EA0121EEE71A2B)]
    public class GcInventorySpecialSlot : NMSTemplate
    {
        /* 0x00 */ public GcInventorySpecialSlotType Type;
        /* 0x04 */ public GcInventoryIndex Index;
    }
}