using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80C23CF2CAA0BC90, NameHash = 0x1FA80ABD4B6B665)]
    public class GcInventoryClassCostMultiplier : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public float[] Multiplier;
    }
}
