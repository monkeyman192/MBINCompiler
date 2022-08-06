using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF7FE8408BD5A0B28, NameHash = 0x63E16E6AF89FE439)]
    public class TkVertexStream : NMSTemplate
    {
        /* 0x0 */ public List<byte> VertexStream;
    }
}
