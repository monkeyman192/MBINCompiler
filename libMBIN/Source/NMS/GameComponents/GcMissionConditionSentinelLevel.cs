namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5BAAC45724E72FD, NameHash = 0x73076E1F)]
    public class GcMissionConditionSentinelLevel : NMSTemplate
    {
        // size: 0x5
        public enum RequiredSentinelLevelEnum : uint {
            None,
            Low,
            Default,
            Aggressive,
            Corrupt,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RequiredSentinelLevelEnum RequiredSentinelLevel;
    }
}
