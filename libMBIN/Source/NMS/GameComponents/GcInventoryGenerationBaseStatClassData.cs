using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42F29F956AA1AB3, NameHash = 0x26C7E9A6)]
    public class GcInventoryGenerationBaseStatClassData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcInventoryGenerationBaseStatDataEntry> BaseStats;
    }
}
