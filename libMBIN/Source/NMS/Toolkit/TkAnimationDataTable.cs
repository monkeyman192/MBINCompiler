using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC65463F97A3C9C1B, NameHash = 0x7D76DCB)]
    public class TkAnimationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimationData> Table;
    }
}
