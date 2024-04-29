using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47DB6FBD869E5818, NameHash = 0xFB7EF63CCFF49839)]
    public class GcAreaDamageDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAreaDamageData> Table;
    }
}
