using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98F3859A288FF087, NameHash = 0x398860441F320FF2)]
    public class GcCreatureBaitComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AttractList;
        /* 0x10 */ public float BaitRadius;
        /* 0x14 */ public float BaitStrength;
        /* 0x18 */ public bool Debug;
        /* 0x19 */ public bool InducesRage;
    }
}
