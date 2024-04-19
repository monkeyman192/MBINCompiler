using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACE410E33E2B84B0, NameHash = 0xAE95337199B47CD)]
    public class GcBaseBuildingPartNavNodeData : NMSTemplate
    {
        /* 0x00 */ public Vector3f AtDir;
        /* 0x10 */ public Vector3f LocalPos;
        /* 0x20 */ public List<uint> ConnectedNodeIndices;
        /* 0x30 */ public NMSString0x10 InteractionID;
        /* 0x40 */ public float ArriveDist;
        /* 0x44 */ public GcNPCNavSubgraphNodeType Type;
    }
}
