using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1FDB156F65F0C69, NameHash = 0x32707F0D00335D4F)]
    public class GcStatsOneShotTypes : NMSTemplate
    {
        public enum StatsOneShotEnum { ShipLanded, ShipLaunched, ShipWarped, WeaponFired }
        public StatsOneShotEnum StatsOneShot;
    }
}
