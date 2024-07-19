using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4795694EA491FB32, NameHash = 0xE45C3809)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcModularCustomisationSlotItemData SlotEmptyCustomisation;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x20A LabelLocID;
        [NMS(Index = 8)]
        /* 0x50 */ public List<NMSString0x20> AssociatedNonProcNodes;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 SlotID;
        [NMS(Index = 10)]
        /* 0x70 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
        [NMS(Index = 7)]
        /* 0x80 */ public NMSString0x10 UISlotGraphicLayer;
        [NMS(Index = 6)]
        /* 0x90 */ public Vector2f UISlotPosition;
        [NMS(Index = 3)]
        /* 0x98 */ public float UILineLengthFactor;
        [NMS(Index = 4)]
        /* 0x9C */ public float UILineMinAngle;
        [NMS(Index = 5)]
        /* 0xA0 */ public NMSString0x20 UILocatorName;
        [NMS(Index = 2)]
        /* 0xC0 */ public bool IncludeInSeed;
    }
}
