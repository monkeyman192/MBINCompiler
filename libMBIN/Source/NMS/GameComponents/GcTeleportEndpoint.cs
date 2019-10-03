using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0xFE8C7F93EF8845D4, NameHash = 0x18CD621AAAB1F01D)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Facing;
		public enum TeleporterTypeEnum { Base, SpaceStation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix }
		public TeleporterTypeEnum TeleporterType;
        [NMS(Size = 0x40)]
        /* 0x44 */ public string Name;
        /* 0x84 */ public bool CalcWarpOffset;
        [NMS(Size = 0xB)]
        /* 0x85 */ public byte[] EndPadding;
    }
}
