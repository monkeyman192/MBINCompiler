using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CDD6A5DC010E409, NameHash = 0xFECA26D94DE68300)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
