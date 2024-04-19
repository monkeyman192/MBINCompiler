using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56D1D8DFC0F07E05, NameHash = 0xF9FB8E431EB1179F)]
    public class GcExplosionDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcExplosionData> Table;
        /* 0x10 */ public NMSString0x80 Name;
    }
}
