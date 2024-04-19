using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86553802E4988FA, NameHash = 0xE9F8FE2C0612C3FE)]
    public class GcBasePlacementRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A PartID;
        /* 0x20 */ public List<NMSTemplate> Conditions;
        // size: 0x5
        public enum TwinCriteriaEnum : uint {
            None,
            MoveToTwin,
            StretchToTwin,
            StretchToRaycast,
            MoveToTwinRelative,
        }
        /* 0x30 */ public TwinCriteriaEnum TwinCriteria;
        /* 0x34 */ public NMSString0x80 PositionLocator;
        /* 0xB4 */ public bool ORConditions;
    }
}
