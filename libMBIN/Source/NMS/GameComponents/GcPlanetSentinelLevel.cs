namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60A1D6C7C2DEB1E, NameHash = 0x7EDB1F462D38BEFC)]
    public class GcPlanetSentinelLevel : NMSTemplate
    {
        // size: 0x4
        public enum SentinelLevelEnum : uint {
            Low,
            Default,
            Aggressive,
            Corrupt,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelLevelEnum SentinelLevel;
    }
}
