using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB117707A282E17C, NameHash = 0x421C6C55)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
