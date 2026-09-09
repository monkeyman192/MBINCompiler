using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3D084D023F4F13D, NameHash = 0x8E41A670)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x20 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 8)]
        /* 0x38 */ public GcAllianceIdSaveData AllianceId;
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
        /* 0x48 */ public TeleporterTypeEnum TeleporterType;
        [NMS(Index = 4)]
        /* 0x4C */ public NMSString0x40 Name;
        [NMS(Index = 5)]
        /* 0x8C */ public bool CalcWarpOffset;
        [NMS(Index = 7)]
        /* 0x8D */ public bool IsFavourite;
        [NMS(Index = 6)]
        /* 0x8E */ public bool IsFeatured;
    }
}
