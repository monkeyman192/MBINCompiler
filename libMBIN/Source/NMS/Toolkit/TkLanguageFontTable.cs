using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7DCCDB6EBEA65AB, NameHash = 0xF4500CD57E96D069)]
    public class TkLanguageFontTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkLanguageFontTableEntry> Table;
    }
}
