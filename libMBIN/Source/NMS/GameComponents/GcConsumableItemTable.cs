using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7530F073486EA46E, NameHash = 0x7D54F1EF)]
    public class GcConsumableItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcConsumableItem> Table;
    }
}
