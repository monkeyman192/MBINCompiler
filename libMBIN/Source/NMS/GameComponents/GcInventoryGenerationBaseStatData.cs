using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FDAB72B65512FAA, NameHash = 0x3E3C580F)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;
    }
}
