using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA478FB9459D28979, NameHash = 0x72C48F33F8324A08)]
    public class TkModelDescriptorList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkResourceDescriptorList> List;
    }
}
