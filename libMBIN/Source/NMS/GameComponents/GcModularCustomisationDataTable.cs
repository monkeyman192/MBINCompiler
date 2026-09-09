using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF968FAC94F74AB4, NameHash = 0x54887B8D)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xC, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0000 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
        [NMS(Index = 2, Size = 0xC, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x1EC0 */ public GcModularCustomisationProductLookupList[] ProductLookupLists;
        [NMS(Index = 1)]
        /* 0x1F80 */ public List<GcModularCustomisationSlottableItemList> SharedSlottableItemLists;
    }
}
