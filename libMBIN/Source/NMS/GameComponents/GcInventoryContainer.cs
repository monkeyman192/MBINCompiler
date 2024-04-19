using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8003F029AE264633, NameHash = 0xAF875892F81EDE11)]
    public class GcInventoryContainer : NMSTemplate
    {
        /* 0x000 */ public List<GcInventoryBaseStatEntry> BaseStatValues;
        /* 0x010 */ public List<GcInventoryElement> Slots;
        /* 0x020 */ public List<GcInventorySpecialSlot> SpecialSlots;
        /* 0x030 */ public List<GcInventoryIndex> ValidSlotIndices;
        /* 0x040 */ public GcInventoryClass Class;
        /* 0x044 */ public int Height;
        /* 0x048 */ public GcInventoryStackSizeGroup StackSizeGroup;
        /* 0x04C */ public int Version;
        /* 0x050 */ public int Width;
        /* 0x054 */ public NMSString0x100 Name;
        /* 0x154 */ public bool IsCool;
    }
}
