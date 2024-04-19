using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB473568C6A036D67, NameHash = 0xD8133C6FC444E667)]
    public class GcBaseLinkGridConnectionData : NMSTemplate
    {
        /* 0x00 */ public List<Vector3f> LinkSocketPositions;
        /* 0x10 */ public List<int> LinkSocketSubGroups;
        /* 0x20 */ public float ConnectionDistance;
        /* 0x24 */ public GcLinkNetworkTypes Network;
        /* 0x28 */ public int NetworkMask;
        /* 0x2C */ public int NetworkSubGroup;
        /* 0x30 */ public bool UseMinDistance;
    }
}
