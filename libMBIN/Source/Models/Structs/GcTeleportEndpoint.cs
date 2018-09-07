using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public Vector4f Position;
        /* 0x30 */ public Vector4f Facing;
		public enum TeleporterTypeEnum { Base, SpaceStation, Atlas, PlanetAwayFromShip, ExternalBase }
		public TeleporterTypeEnum TeleporterType;
        [NMS(Size = 0x40)]
        /* 0x44 */ public string Name;
        [NMS(Size = 0xC)]
        /* 0x84 */ public byte[] EndPadding;
    }
}
