using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF725AC20531781D1, NameHash = 0xAA6A73C6FF45C9F8)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public GcModularCustomisationSlotItemData SlotEmptyCustomisation;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x20A LabelLocID;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 SlotID;
        [NMS(Index = 9)]
        /* 0x60 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
        [NMS(Index = 7)]
        /* 0x70 */ public NMSString0x10 UISlotGraphicLayer;
        [NMS(Index = 6)]
        /* 0x80 */ public Vector2f UISlotPosition;
        [NMS(Index = 3)]
        /* 0x88 */ public float UILineLengthFactor;
        [NMS(Index = 4)]
        /* 0x8C */ public float UILineMinAngle;
        [NMS(Index = 5)]
        /* 0x90 */ public NMSString0x20 UILocatorName;
        [NMS(Index = 2)]
        /* 0xB0 */ public bool IncludeInSeed;
    }
}
