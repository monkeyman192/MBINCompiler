using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEE57EA821B0FFCB4, NameHash = 0x7D76DCB)]
    public class TkAnimationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimationData> Table;
    }
}
