using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBAC3D419B5356A8, NameHash = 0x7A13912B545C6365)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;
    }
}
