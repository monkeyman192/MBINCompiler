using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x132BDAD59280EC19, NameHash = 0xF9FB8E431EB1179F)]
    public class GcExplosionDataTable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Name;
        /* 0x80 */ public List<GcExplosionData> Table;
    }
}
