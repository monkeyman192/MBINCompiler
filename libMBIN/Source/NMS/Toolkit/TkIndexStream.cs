using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5DE90A99B7A2C564, NameHash = 0x1A553772)]
    public class TkIndexStream : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<int> IndexStream;
    }
}
