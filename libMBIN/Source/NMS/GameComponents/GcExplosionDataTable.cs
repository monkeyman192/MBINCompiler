using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FD80C6B9F94546A, NameHash = 0x61BD77C0)]
    public class GcExplosionDataTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcExplosionData> Table;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 Name;
    }
}
