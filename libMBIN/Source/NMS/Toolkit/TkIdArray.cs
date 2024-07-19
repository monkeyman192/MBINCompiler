using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x428553BDCE6FB2E2, NameHash = 0xC3614740)]
    public class TkIdArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> Array;
    }
}
