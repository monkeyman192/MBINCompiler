using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA5C891B043A1F0F3, NameHash = 0xECE6F42F8A522B34)]
    public class GcTeleporterType : NMSTemplate
    {
		public enum TeleporterDestinationTypeEnum { Base, Spacestation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix }
		public TeleporterDestinationTypeEnum TeleporterDestinationType;
    }
}
