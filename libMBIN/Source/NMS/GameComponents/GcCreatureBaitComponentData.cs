using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22582597D4A81E79, NameHash = 0xD3DE4B63)]
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
