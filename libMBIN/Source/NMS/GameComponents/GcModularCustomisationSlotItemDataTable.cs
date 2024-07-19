using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE128B651AC498701, NameHash = 0xEDA980F)]
    public class GcModularCustomisationSlotItemDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcModularCustomisationSlotItemData> Table;
    }
}
