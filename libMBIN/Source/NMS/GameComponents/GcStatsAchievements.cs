namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C4D510DA52511C5, NameHash = 0xADDED46314D20DE5)]
    public class GcStatsAchievements : NMSTemplate
    {
        // size: 0x2
        public enum StatsAchievementsEnum : uint {
            FirstWarp,
            FirstDiscovery,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatsAchievementsEnum StatsAchievements;
    }
}
