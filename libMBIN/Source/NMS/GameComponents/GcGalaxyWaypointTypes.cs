namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35632D9AFE0F476F, NameHash = 0xF808614547AF2B25)]
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        // size: 0x6
        public enum GalaxyWaypointTypeEnum : uint {
            User,
            Gameplay_AtlasStation,
            Gameplay_DistressBeacon,
            Gameplay_BlackHole,
            Gameplay_Mission,
            Gameplay_SeasonParty,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}
