using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x160, GUID = 0x2F97654090258A71, NameHash = 0xAF875892F81EDE11)]
    public class GcInventoryContainer : NMSTemplate
    {
        /* 0x00 */ public List<GcInventoryElement> Slots;
        /* 0x10 */ public List<GcInventoryIndex> ValidSlotIndices;
        /* 0x20 */ public GcInventoryClass Class;
        /* 0x24 */ public int SubstanceMaxStorageMultiplier;
        /* 0x28 */ public int ProductMaxStorageMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        /* 0x30 */ public List<GcInventoryBaseStatEntry> BaseStatValues;
        /* 0x40 */ public List<GcInventorySpecialSlot> SpecialSlots;
        /* 0x50 */ public int Width;
        /* 0x54 */ public int Height;
        /* 0x58 */ public bool IsCool;
        /* 0x59 */ public NMSString0x100 Name;
        /* 0x15C */ public int Version;
    }
}
