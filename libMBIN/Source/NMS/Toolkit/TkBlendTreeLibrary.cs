using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE212452D62D67AD8, NameHash = 0xBB62146B)]
    public class TkBlendTreeLibrary : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimBlendTree> Trees;
    }
}
