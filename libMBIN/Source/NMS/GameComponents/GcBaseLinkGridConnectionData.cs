using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xB0499C9E72D31AC0, NameHash = 0xD8133C6FC444E667)]
    public class GcBaseLinkGridConnectionData : NMSTemplate
    {
        /* 0x00 */ public GcLinkNetworkTypes Network;
        /* 0x04 */ public int NetworkSubGroup;
        /* 0x08 */ public int NetworkMask;
        /* 0x0C */ public float ConnectionDistance;
        /* 0x10 */ public bool UseMinDistance;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] Padding11;
        /* 0x18 */ public List<Vector4f> LinkSocketPositions;
        /* 0x28 */ public List<int> LinkSocketSubGroups;
    }
}
