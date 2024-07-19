namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26885B9B57AC27F0, NameHash = 0x1CF29A75)]
    public class GcStatsOneShotTypes : NMSTemplate
    {
        // size: 0x4
        public enum StatsOneShotEnum : uint {
            ShipLanded,
            ShipLaunched,
            ShipWarped,
            WeaponFired,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatsOneShotEnum StatsOneShot;
    }
}
