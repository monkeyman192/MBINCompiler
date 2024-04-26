using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE57FFA12D698E95, NameHash = 0x6955787592193D13)]
    public class TkAnimationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimationData> Table;
    }
}
