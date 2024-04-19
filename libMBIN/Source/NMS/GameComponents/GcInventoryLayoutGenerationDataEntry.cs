using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4143974B3CF4098, NameHash = 0x15DCF5F4B3591EDB)]
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate
    {
        /* 0x00 */ public GcInventoryLayoutGenerationBounds Bounds;
        /* 0x18 */ public GcInventoryLayoutGenerationBounds TechBounds;
        /* 0x30 */ public GcInventoryIndex SpecialTechSlotMaxIndex;
        /* 0x38 */ public int MaxCargoSlots;
        /* 0x3C */ public int MaxNumSpecialTechSlots;
        /* 0x40 */ public int MaxSlots;
        /* 0x44 */ public int MaxTechSlots;
        /* 0x48 */ public int MinCargoSlots;
        /* 0x4C */ public int MinSlots;
        /* 0x50 */ public int MinTechSlots;
    }
}
