using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A84C9749A59EA2D, NameHash = 0x57BF641A)]
    public class GcBaseLinkGridConnectionData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<Vector3f> LinkSocketPositions;
        [NMS(Index = 6)]
        /* 0x10 */ public List<int> LinkSocketSubGroups;
        [NMS(Index = 3)]
        /* 0x20 */ public float ConnectionDistance;
        [NMS(Index = 0)]
        /* 0x24 */ public GcLinkNetworkTypes Network;
        [NMS(Index = 2)]
        /* 0x28 */ public int NetworkMask;
        [NMS(Index = 1)]
        /* 0x2C */ public int NetworkSubGroup;
        [NMS(Index = 4)]
        /* 0x30 */ public bool UseMinDistance;
    }
}
