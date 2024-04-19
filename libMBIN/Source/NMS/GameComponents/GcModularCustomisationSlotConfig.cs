using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18F7A66D01714010, NameHash = 0xAA6A73C6FF45C9F8)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        /* 0x00 */ public GcModularCustomisationSlotItemData SlotEmptyCustomisation;
        /* 0x30 */ public NMSString0x20A LabelLocID;
        /* 0x50 */ public NMSString0x10 SlotID;
        /* 0x60 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
        /* 0x70 */ public NMSString0x10 UISlotGraphicLayer;
        /* 0x80 */ public Vector2f UISlotPosition;
        /* 0x88 */ public float UILineLengthFactor;
        /* 0x8C */ public float UILineMinAngle;
        /* 0x90 */ public NMSString0x20 UILocatorName;
        /* 0xB0 */ public bool IncludeInSeed;
    }
}
