using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83CA5673449CD365, NameHash = 0xDE0D8B1D5DF55902)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
    }
}
