using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCB4FAC8D44DA285, NameHash = 0x8E41A670)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Position;
        [NMS(Index = 0)]
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
        [NMS(Index = 3)]
        /* 0x38 */ public TeleporterTypeEnum TeleporterType;
        [NMS(Index = 4)]
        /* 0x3C */ public NMSString0x40 Name;
        [NMS(Index = 5)]
        /* 0x7C */ public bool CalcWarpOffset;
        [NMS(Index = 6)]
        /* 0x7D */ public bool IsFeatured;
    }
}
