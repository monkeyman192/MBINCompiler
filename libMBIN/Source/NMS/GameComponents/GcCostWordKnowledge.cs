using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA87177E4DD4C433, NameHash = 0x24CDB22E)]
    public class GcCostWordKnowledge : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAlienRace Race;
        // size: 0x2
        public enum RequirementEnum : uint {
            CanLearn,
            CanSpeak,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public RequirementEnum Requirement;
    }
}
