using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4708CCEB9DC9B88, NameHash = 0xD9472E9B798FC3B5)]
    public class GcInventoryCostDataEntry : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public float[] ClassMultiplier;
        /* 0x10 */ public float CoolMultiplier;
        /* 0x14 */ public int MaxSlots;
        /* 0x18 */ public float MaxValueInMillions;
        /* 0x1C */ public int MinSlots;
        /* 0x20 */ public float MinValueInMillions;
        /* 0x24 */ public float TradeInMultiplier;
    }
}
