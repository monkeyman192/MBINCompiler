namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCD95EDB97D142FC, NameHash = 0x4CF5A27A1458612D)]
    public class TkMeshMetaData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 IdString;
        /* 0x80 */ public ulong Hash;
        /* 0x88 */ public int VertexDataSize;
        /* 0x8C */ public int VertexDataOffset;
        /* 0x90 */ public int IndexDataSize;
        /* 0x94 */ public int IndexDataOffset;
        /* 0x98 */ public bool DoubleBufferGeometry;
    }
}
