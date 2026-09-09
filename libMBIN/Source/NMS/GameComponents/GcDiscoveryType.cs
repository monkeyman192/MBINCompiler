namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F85BB78B71D2144, NameHash = 0x35BA4E99)]
    public class GcDiscoveryType : NMSTemplate
    {
        // size: 0x13
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
            SpacePoi,
            SpaceStation,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DiscoveryTypeEnum DiscoveryType;
    }
}
