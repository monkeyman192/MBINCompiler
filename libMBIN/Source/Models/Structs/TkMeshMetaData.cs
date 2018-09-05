namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x98)]
    public class TkMeshMetaData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string IdString;
        /* 0x80 */ public ulong Hash;
        /* 0x88 */ public int VertexDataSize;
        /* 0x8C */ public int VertexDataOffset;
        /* 0x90 */ public int IndexDataSize;
        /* 0x94 */ public int IndexDataOffset;
    }
}
