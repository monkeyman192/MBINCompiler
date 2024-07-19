using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20FBF0BC72CD2081, NameHash = 0x36EC0D1C)]
    public class GcLeveledStatTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcLeveledStatData> LeveledStatTable;
    }
}
