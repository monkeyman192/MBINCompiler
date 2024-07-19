using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3751A93D522509C, NameHash = 0x6BF62723)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateTraitData> Traits;
    }
}
