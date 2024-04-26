namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE4AB318918F5504, NameHash = 0x77560873BF71CDAB)]
    public class GcStatsValueTypes : NMSTemplate
    {
        // size: 0x4
        public enum StatsValueEnum : uint {
            DistanceJetpacked,
            DistanceWalked,
            DistanceWarped,
            DamageSustained,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatsValueEnum StatsValue;
    }
}
