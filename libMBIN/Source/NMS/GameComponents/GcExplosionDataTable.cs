using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19C7C0DF3ECB85D7, NameHash = 0x61BD77C0)]
    public class GcExplosionDataTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcExplosionData> Table;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 Name;
    }
}
