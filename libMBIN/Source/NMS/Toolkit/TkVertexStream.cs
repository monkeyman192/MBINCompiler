using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3C047A7B478F69D4, NameHash = 0x63E16E6AF89FE439)]
    public class TkVertexStream : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<byte> VertexStream;
    }
}
