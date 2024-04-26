using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DB9F5AD070A4647, NameHash = 0xADE121F93A7D37D0)]
    public class GcInventoryGenerationBaseStatClassData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcInventoryGenerationBaseStatDataEntry> BaseStats;
    }
}
