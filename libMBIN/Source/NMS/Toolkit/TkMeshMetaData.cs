namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCD95EDB97D142FC, NameHash = 0x4CF5A27A1458612D)]
    public class TkMeshMetaData : NMSTemplate
    {
        /* 0x00 */ public ulong Hash;
        /* 0x08 */ public int IndexDataOffset;
        /* 0x0C */ public int IndexDataSize;
        /* 0x10 */ public int VertexDataOffset;
        /* 0x14 */ public int VertexDataSize;
        /* 0x18 */ public NMSString0x80 IdString;
        /* 0x98 */ public bool DoubleBufferGeometry;
    }
}
