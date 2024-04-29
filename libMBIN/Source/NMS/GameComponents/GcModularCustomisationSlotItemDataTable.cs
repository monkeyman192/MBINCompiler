using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49D8A8779064C855, NameHash = 0x91F7DF60D7B1A0C6)]
    public class GcModularCustomisationSlotItemDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcModularCustomisationSlotItemData> Table;
    }
}
