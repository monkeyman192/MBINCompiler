using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB48E524841751DD, NameHash = 0x539FCC01)]
    public class InfluencesOnMappedPoint : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<MappingInfluence> Influences;
    }
}
