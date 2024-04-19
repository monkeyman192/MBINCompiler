using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA4F0B98C8572FC, NameHash = 0x18CD621AAAB1F01D)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        /* 0x00 */ public Vector3f Facing;
        /* 0x10 */ public Vector3f Position;
        /* 0x20 */ public GcUniverseAddressData UniverseAddress;
        // size: 0xB
        public enum TeleporterTypeEnum : uint {
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
            Frigate,
        }
        /* 0x38 */ public TeleporterTypeEnum TeleporterType;
        /* 0x3C */ public NMSString0x40 Name;
        /* 0x7C */ public bool CalcWarpOffset;
        /* 0x7D */ public bool IsFeatured;
    }
}
