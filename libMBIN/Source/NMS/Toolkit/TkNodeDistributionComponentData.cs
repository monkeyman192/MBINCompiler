using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6E94D6A73D9347DA, NameHash = 0x1EE5F1E2)]
    public class TkNodeDistributionComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkNodeDistributionEntry> Entries;
        [NMS(Index = 1)]
        /* 0x10 */ public bool HideNotDestroy;
    }
}
