using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB99CEF28BBC9410A, NameHash = 0x4CF5A27A1458612D)]
    public class TkMeshMetaData : NMSTemplate
    {
        [NMS(Size = 0x80, Padding = 0xFE)]
        /* 0x00 */ public string IdString;
        /* 0x80 */ public ulong Hash;
        /* 0x88 */ public int VertexDataSize;
        /* 0x8C */ public int VertexDataOffset;
        /* 0x90 */ public int IndexDataSize;
        /* 0x94 */ public int IndexDataOffset;
        /* 0x98 */ public bool DoubleBufferGeometry;
    }
}
