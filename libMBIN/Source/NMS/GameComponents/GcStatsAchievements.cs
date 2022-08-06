using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3831A5BA50281050, NameHash = 0xADDED46314D20DE5)]
    public class GcStatsAchievements : NMSTemplate
    {
        public enum StatsAchievementsEnum { FirstWarp, FirstDiscovery }
        public StatsAchievementsEnum StatsAchievements;
    }
}
