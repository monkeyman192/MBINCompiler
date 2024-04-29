using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9491CC24FCE6B543, NameHash = 0x891585A60DC0D014)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
