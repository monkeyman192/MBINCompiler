using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x250C354FF90C1E93, NameHash = 0xD8133C6FC444E667)]
    public class GcBaseLinkGridConnectionData : NMSTemplate
    {
        /* 0x00 */ public GcLinkNetworkTypes Network;
        /* 0x04 */ public int NetworkSubGroup;
        /* 0x08 */ public int NetworkMask;
        /* 0x0C */ public float ConnectionDistance;
        /* 0x10 */ public bool UseMinDistance;
        /* 0x18 */ public List<Vector3f> LinkSocketPositions;
        /* 0x28 */ public List<int> LinkSocketSubGroups;
    }
}
