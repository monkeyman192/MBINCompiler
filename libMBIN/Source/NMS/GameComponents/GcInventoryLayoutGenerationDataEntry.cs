using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A648A4D27CAED40, NameHash = 0x15DCF5F4B3591EDB)]
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public GcInventoryLayoutGenerationBounds Bounds;
        [NMS(Index = 7)]
        /* 0x18 */ public GcInventoryLayoutGenerationBounds TechBounds;
        [NMS(Index = 9)]
        /* 0x30 */ public GcInventoryIndex SpecialTechSlotMaxIndex;
        [NMS(Index = 5)]
        /* 0x38 */ public int MaxCargoSlots;
        [NMS(Index = 8)]
        /* 0x3C */ public int MaxNumSpecialTechSlots;
        [NMS(Index = 1)]
        /* 0x40 */ public int MaxSlots;
        [NMS(Index = 3)]
        /* 0x44 */ public int MaxTechSlots;
        [NMS(Index = 4)]
        /* 0x48 */ public int MinCargoSlots;
        [NMS(Index = 0)]
        /* 0x4C */ public int MinSlots;
        [NMS(Index = 2)]
        /* 0x50 */ public int MinTechSlots;
    }
}
