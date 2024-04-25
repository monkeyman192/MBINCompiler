using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98F3859A288FF087, NameHash = 0x398860441F320FF2)]
    public class GcCreatureBaitComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> AttractList;
        [NMS(Index = 2)]
        /* 0x10 */ public float BaitRadius;
        [NMS(Index = 1)]
        /* 0x14 */ public float BaitStrength;
        [NMS(Index = 3)]
        /* 0x18 */ public bool Debug;
        [NMS(Index = 4)]
        /* 0x19 */ public bool InducesRage;
    }
}
