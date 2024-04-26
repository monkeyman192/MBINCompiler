using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69322AB0FB28C055, NameHash = 0xB2EA0121EEE71A2B)]
    public class GcInventorySpecialSlot : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInventoryIndex Index;
        [NMS(Index = 0)]
        /* 0x8 */ public GcInventorySpecialSlotType Type;
    }
}
