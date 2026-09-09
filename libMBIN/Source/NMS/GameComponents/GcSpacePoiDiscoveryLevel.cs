namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x439180306DDAAD0B, NameHash = 0xCC7335AC)]
    public class GcSpacePoiDiscoveryLevel : NMSTemplate
    {
        // size: 0x4
        public enum SpacePoiDiscoveryLevelEnum : uint {
            Hidden,
            Undiscovered,
            Discovered,
            Completed,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpacePoiDiscoveryLevelEnum SpacePoiDiscoveryLevel;
    }
}
