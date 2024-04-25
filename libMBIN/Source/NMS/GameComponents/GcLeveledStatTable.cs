using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41849BF0E1C6B793, NameHash = 0x7169FE9CB058F962)]
    public class GcLeveledStatTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcLeveledStatData> LeveledStatTable;
    }
}
