using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4285EBDE23CA846, NameHash = 0x77560873BF71CDAB)]
    public class GcStatsValueTypes : NMSTemplate
    {
        public enum StatsValueEnum { DistanceJetpacked, DistanceWalked, DistanceWarped, DamageSustained }
        public StatsValueEnum StatsValue;
    }
}
