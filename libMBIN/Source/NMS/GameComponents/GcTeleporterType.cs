namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9A0D4A857566650, NameHash = 0x87A754F4)]
    public class GcTeleporterType : NMSTemplate
    {
        // size: 0xA
        public enum TeleporterDestinationTypeEnum : uint {
            Base,
            Spacestation,
            Atlas,
            PlanetAwayFromShip,
            ExternalBase,
            EmergencyGalaxyFix,
            OnNexus,
            SpacestationFixPosition,
            Settlement,
            Freighter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TeleporterDestinationTypeEnum TeleporterDestinationType;
    }
}
