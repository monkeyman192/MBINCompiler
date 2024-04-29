using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x752F39DA30FD3B38, NameHash = 0x53E5A2C89515A4E1)]
    public class GcCreatureDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureData> Table;
    }
}
