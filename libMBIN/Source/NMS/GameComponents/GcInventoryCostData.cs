using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE906145DEB44728, NameHash = 0x427DC96C)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
