using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FDD1602DA79FE6B, NameHash = 0x4992418A4C059481)]
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCreatureStupidName> Table;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 StupidUserName;
    }
}
