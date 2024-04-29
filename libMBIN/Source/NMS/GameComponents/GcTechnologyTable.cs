using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3393807B0E4B0BE, NameHash = 0x7BF27C8F05ED20B7)]
    public class GcTechnologyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTechnology> Table;
    }
}
