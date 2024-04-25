namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EB28DC3AE2177C7, NameHash = 0x651218B208D538A0)]
    public class GcMissionConditionAbandonedOrEmptySystem : NMSTemplate
    {
        // size: 0x3
        public enum MissionSystemTypeEnum : uint {
            Either,
            Empty,
            Abandoned,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionSystemTypeEnum MissionSystemType;
    }
}
