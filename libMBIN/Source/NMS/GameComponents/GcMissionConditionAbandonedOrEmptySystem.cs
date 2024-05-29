namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD109CD7ECAB278D9, NameHash = 0x651218B208D538A0)]
    public class GcMissionConditionAbandonedOrEmptySystem : NMSTemplate
    {
        // size: 0x4
        public enum MissionSystemTypeEnum : uint {
            Either,
            Empty,
            Abandoned,
            SeasonForcedAbandoned,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionSystemTypeEnum MissionSystemType;
    }
}
