namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1815B0A103BF81B7, NameHash = 0x34D109FC6FD5709)]
    public class GcScanEventTableType : NMSTemplate
    {
        // size: 0x8
        public enum ScanTableEnum : uint {
            Space,
            Planet ,
            Missions,
            Tutorial,
            MissionsCreative,
            Vehicle,
            NPCPlanetSite,
            Seasonal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanTableEnum ScanTable;
    }
}
