using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x551DCEAB38A46276, NameHash = 0xF8DBEB64)]
    public class TkLocalisationTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkLocalisationEntry> Table;
    }
}
