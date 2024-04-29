using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x147CA91F90A7656E, NameHash = 0xDE0D8B1D5DF55902)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
    }
}
