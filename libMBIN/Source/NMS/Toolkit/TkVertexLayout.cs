using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x74A979AD2A0CECB6, NameHash = 0xDD31F212063601F7)]
    public class TkVertexLayout : NMSTemplate
    {
        /* 0x00 */ public List<TkVertexElement> VertexElements;
        /* 0x10 */ public long PlatformData;
        /* 0x18 */ public int ElementCount;
        /* 0x1C */ public int Stride;
    }
}
