using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x70272DC777DDD6BD, NameHash = 0x18D05F06)]
    public class TkMeshData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString IdString;
        [NMS(Index = 4)]
        /* 0x10 */ public List<byte> MeshDataStream;
        [NMS(Index = 1)]
        /* 0x20 */ public ulong Hash;
        [NMS(Index = 3)]
        /* 0x28 */ public int IndexDataSize;
        [NMS(Index = 2)]
        /* 0x2C */ public int VertexDataSize;
    }
}
