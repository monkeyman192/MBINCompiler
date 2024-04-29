using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AE707D361E0AF48, NameHash = 0xE9F8FE2C0612C3FE)]
    public class GcBasePlacementRule : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A PartID;
        [NMS(Index = 0)]
        /* 0x20 */ public List<NMSTemplate> Conditions;
        // size: 0x5
        public enum TwinCriteriaEnum : uint {
            None,
            MoveToTwin,
            StretchToTwin,
            StretchToRaycast,
            MoveToTwinRelative,
        }
        [NMS(Index = 4)]
        /* 0x30 */ public TwinCriteriaEnum TwinCriteria;
        [NMS(Index = 1)]
        /* 0x34 */ public NMSString0x80 PositionLocator;
        [NMS(Index = 3)]
        /* 0xB4 */ public bool ORConditions;
    }
}
