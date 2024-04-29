namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC2D284E3D974083C, NameHash = 0x4CF5A27A1458612D)]
    public class TkMeshMetaData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public ulong Hash;
        [NMS(Index = 5)]
        /* 0x08 */ public int IndexDataOffset;
        [NMS(Index = 4)]
        /* 0x0C */ public int IndexDataSize;
        [NMS(Index = 3)]
        /* 0x10 */ public int VertexDataOffset;
        [NMS(Index = 2)]
        /* 0x14 */ public int VertexDataSize;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x80 IdString;
        [NMS(Index = 6)]
        /* 0x98 */ public bool DoubleBufferGeometry;
    }
}
