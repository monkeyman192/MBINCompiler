using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3862A44992FE2FF0, NameHash = 0xDE0D8B1D5DF55902)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
    }
}
