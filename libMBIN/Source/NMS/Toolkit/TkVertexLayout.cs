using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBBDFD1D02ECAFE8A, NameHash = 0xDD31F212063601F7)]
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
