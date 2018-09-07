namespace libMBIN.Models.Structs
{
    public class GcTeleporterType : NMSTemplate
    {
		public enum TeleporterDestinationTypeEnum { Base, Spacestation, Atlas, PlanetAwayFromShip }
		public TeleporterDestinationTypeEnum TeleporterDestinationType;
    }
}
