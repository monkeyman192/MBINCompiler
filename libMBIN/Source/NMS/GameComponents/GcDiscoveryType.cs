namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9066D5BF2A5AAA32, NameHash = 0x5BB97397B6B70C3A)]
    public class GcDiscoveryType : NMSTemplate
    {
        // size: 0x11
        public enum DiscoveryTypeEnum : uint {
            Unknown,
            SolarSystem,
            Planet,
            Animal,
            Flora,
            Mineral,
            Sector,
            Building,
            Interactable,
            Sentinel,
            Starship,
            Artifact,
            Mystery,
            Treasure,
            Control,
            HarvestPlant,
            FriendlyDrone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DiscoveryTypeEnum DiscoveryType;
    }
}
