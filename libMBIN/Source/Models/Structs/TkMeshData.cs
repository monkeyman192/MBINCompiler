using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA0)]
    public class TkMeshData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string IdString;
        /* 0x80 */ public ulong Hash;
        /* 0x88 */ public int VertexDataSize;
        /* 0x8C */ public int IndexDataSize;
        ///* 0x90 */ public List<float> MeshDataStream;   // not really but yeah
    }
}
