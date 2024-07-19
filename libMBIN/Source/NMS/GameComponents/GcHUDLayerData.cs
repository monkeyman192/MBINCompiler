using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33691F8D2E7172E7, NameHash = 0xA73B9709)]
    public class GcHUDLayerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x28 */ public List<NMSTemplate> Children;
    }
}
