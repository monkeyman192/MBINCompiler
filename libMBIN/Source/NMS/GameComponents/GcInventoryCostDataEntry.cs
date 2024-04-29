using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D074719CE60432B, NameHash = 0xD9472E9B798FC3B5)]
    public class GcInventoryCostDataEntry : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public float[] ClassMultiplier;
        [NMS(Index = 4)]
        /* 0x10 */ public float CoolMultiplier;
        [NMS(Index = 2)]
        /* 0x14 */ public int MaxSlots;
        [NMS(Index = 3)]
        /* 0x18 */ public float MaxValueInMillions;
        [NMS(Index = 0)]
        /* 0x1C */ public int MinSlots;
        [NMS(Index = 1)]
        /* 0x20 */ public float MinValueInMillions;
        [NMS(Index = 5)]
        /* 0x24 */ public float TradeInMultiplier;
    }
}
