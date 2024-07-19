using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9B154DCDD08F7A8, NameHash = 0x54887B8D)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
    }
}
