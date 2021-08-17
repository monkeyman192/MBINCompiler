using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x20, GUID = 0xB5F73B43F19328BA, NameHash = 0xDD31F212063601F7)]
    public class TkVertexLayout : NMSTemplate
    {
        /* 0x00 */ public int ElementCount;
        /* 0x04 */ public int Stride;
        /* 0x08 */ public long PlatformData;
        /* 0x10 */ public List<TkVertexElement> VertexElements;
    }
}
