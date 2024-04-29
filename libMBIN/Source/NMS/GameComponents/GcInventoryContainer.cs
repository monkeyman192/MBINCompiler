using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C43DFEB6783A4CC, NameHash = 0xAF875892F81EDE11)]
    public class GcInventoryContainer : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public List<GcInventoryBaseStatEntry> BaseStatValues;
        [NMS(Index = 0)]
        /* 0x010 */ public List<GcInventoryElement> Slots;
        [NMS(Index = 5)]
        /* 0x020 */ public List<GcInventorySpecialSlot> SpecialSlots;
        [NMS(Index = 1)]
        /* 0x030 */ public List<GcInventoryIndex> ValidSlotIndices;
        [NMS(Index = 2)]
        /* 0x040 */ public GcInventoryClass Class;
        [NMS(Index = 7)]
        /* 0x044 */ public int Height;
        [NMS(Index = 3)]
        /* 0x048 */ public GcInventoryStackSizeGroup StackSizeGroup;
        [NMS(Index = 10)]
        /* 0x04C */ public int Version;
        [NMS(Index = 6)]
        /* 0x050 */ public int Width;
        [NMS(Index = 9)]
        /* 0x054 */ public NMSString0x100 Name;
        [NMS(Index = 8)]
        /* 0x154 */ public bool IsCool;
    }
}
