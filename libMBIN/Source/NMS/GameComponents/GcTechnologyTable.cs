using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEEDB3A570FEE85E, NameHash = 0x14FDBFDE)]
    public class GcTechnologyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTechnology> Table;
    }
}
