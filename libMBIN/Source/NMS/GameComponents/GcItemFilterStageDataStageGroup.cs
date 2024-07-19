using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E169C2528B96FFF, NameHash = 0xE4ECE0F2)]
    public class GcItemFilterStageDataStageGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSTemplate> Children;
        // size: 0x2
        public enum FilterStageGroupOperatorEnum : uint {
            AND,
            OR,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public FilterStageGroupOperatorEnum FilterStageGroupOperator;
    }
}
