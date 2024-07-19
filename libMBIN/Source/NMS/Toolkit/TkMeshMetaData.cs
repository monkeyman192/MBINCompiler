namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x94BD5022544C6C42, NameHash = 0x6C564DBA)]
    public class TkMeshMetaData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString IdString;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong Hash;
        [NMS(Index = 5)]
        /* 0x18 */ public int IndexDataOffset;
        [NMS(Index = 4)]
        /* 0x1C */ public int IndexDataSize;
        [NMS(Index = 3)]
        /* 0x20 */ public int VertexDataOffset;
        [NMS(Index = 2)]
        /* 0x24 */ public int VertexDataSize;
        [NMS(Index = 6)]
        /* 0x28 */ public bool DoubleBufferGeometry;
    }
}
