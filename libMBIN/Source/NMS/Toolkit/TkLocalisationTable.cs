using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x25CB0A6A8D3DD951, NameHash = 0x2969CA92E6538A9A)]
    public class TkLocalisationTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkLocalisationEntry> Table;
    }
}
