using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15648BEF0189B823, NameHash = 0xA9AA29AB69917BF0)]
    public class GcConsumableItemTable : NMSTemplate
    {
        /* 0x0 */ public List<GcConsumableItem> Table;
    }
}
