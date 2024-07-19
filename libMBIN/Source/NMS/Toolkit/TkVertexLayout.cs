using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1F27018E19BAA4FE, NameHash = 0x33314386)]
    public class TkVertexLayout : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<TkVertexElement> VertexElements;
        [NMS(Index = 2)]
        /* 0x10 */ public long PlatformData;
        [NMS(Index = 0)]
        /* 0x18 */ public int ElementCount;
        [NMS(Index = 1)]
        /* 0x1C */ public int Stride;
    }
}
