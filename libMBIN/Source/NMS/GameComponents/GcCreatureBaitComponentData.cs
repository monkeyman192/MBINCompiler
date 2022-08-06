using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DDDBDFBD1267CE7, NameHash = 0x398860441F320FF2)]
    public class GcCreatureBaitComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AttractList;
        /* 0x10 */ public float BaitStrength;
        /* 0x14 */ public float BaitRadius;
        /* 0x18 */ public bool Debug;
        /* 0x19 */ public bool InducesRage;
    }
}
