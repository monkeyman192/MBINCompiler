using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2885A5C8155BCEB0, NameHash = 0xE07E83B8A167074C)]
    public class GcStatGroupTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatGroupData> StatGroupTable;
    }
}
