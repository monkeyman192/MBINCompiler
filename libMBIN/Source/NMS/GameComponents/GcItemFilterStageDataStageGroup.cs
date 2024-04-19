using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E82A5A0ACA9E521, NameHash = 0x65B5F0F2C696033C)]
    public class GcItemFilterStageDataStageGroup : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Children;
        // size: 0x2
        public enum FilterStageGroupOperatorEnum : uint {
            AND,
            OR,
        }
        /* 0x10 */ public FilterStageGroupOperatorEnum FilterStageGroupOperator;
    }
}
