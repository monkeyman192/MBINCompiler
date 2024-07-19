using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCAFADE45EEAEC628, NameHash = 0xEC25B86A)]
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCreatureStupidName> Table;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 StupidUserName;
    }
}
