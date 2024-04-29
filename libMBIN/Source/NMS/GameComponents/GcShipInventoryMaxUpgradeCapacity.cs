using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD793073DF62EF55, NameHash = 0xC51C8A0A49F892DC)]
    public class GcShipInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public int[] MaxCargoInventoryCapacity;
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x10 */ public int[] MaxInventoryCapacity;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x20 */ public int[] MaxTechInventoryCapacity;
    }
}
