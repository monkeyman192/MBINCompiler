using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA6E1BB1C26B5916, NameHash = 0x392CEA8FE98D0F4)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x00000 */ public Colour[] ScannableColours;
        [NMS(Size = 0x4)]
        /* 0x00420 */ public Colour[] NetworkFSPlayerColours;
        /* 0x00460 */ public Colour BuildingColour;
        /* 0x00470 */ public Colour GenericColour;
        /* 0x00480 */ public Colour RelicColour;
        /* 0x00490 */ public Colour SignalColour;
        /* 0x004A0 */ public Colour UnknownColour;
        [NMS(Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x004B0 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x049C8 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x08EE0 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x0B384 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x0D828 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x0FCCC */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x4)]
        /* 0x10314 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x10744 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x10B74 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x10FA4 */ public TkTextureResource[] HighlightIcons;
        /* 0x11238 */ public GcScannerIcon ArrowLarge;
        /* 0x11344 */ public GcScannerIcon ArrowSmall;
        /* 0x11450 */ public GcScannerIcon BaseBuildingMarker;
        /* 0x1155C */ public GcScannerIcon Battle;
        /* 0x11668 */ public GcScannerIcon BattleSmall;
        /* 0x11774 */ public GcScannerIcon BlackHole;
        /* 0x11880 */ public GcScannerIcon Bounty1;
        /* 0x1198C */ public GcScannerIcon Bounty2;
        /* 0x11A98 */ public GcScannerIcon Bounty3;
        /* 0x11BA4 */ public GcScannerIcon BountySmall;
        /* 0x11CB0 */ public GcScannerIcon Checkpoint;
        /* 0x11DBC */ public GcScannerIcon CircleAnimation;
        /* 0x11EC8 */ public GcScannerIcon CreatureAction;
        /* 0x11FD4 */ public GcScannerIcon CreatureCurious;
        /* 0x120E0 */ public GcScannerIcon CreatureDanger;
        /* 0x121EC */ public GcScannerIcon CreatureDiscovered;
        /* 0x122F8 */ public GcScannerIcon CreatureFiend;
        /* 0x12404 */ public GcScannerIcon CreatureInteraction;
        /* 0x12510 */ public GcScannerIcon CreatureMilk;
        /* 0x1261C */ public GcScannerIcon CreatureTame;
        /* 0x12728 */ public GcScannerIcon CreatureUndiscovered;
        /* 0x12834 */ public GcScannerIcon CreatureUnknown;
        /* 0x12940 */ public GcScannerIcon DamagedFrigate;
        /* 0x12A4C */ public GcScannerIcon Death;
        /* 0x12B58 */ public GcScannerIcon DeathSmall;
        /* 0x12C64 */ public GcScannerIcon DiamondAnimation;
        /* 0x12D70 */ public GcScannerIcon EditingBase;
        /* 0x12E7C */ public GcScannerIcon Expedition;
        /* 0x12F88 */ public GcScannerIcon Freighter;
        /* 0x13094 */ public GcScannerIcon FreighterBase;
        /* 0x131A0 */ public GcScannerIcon FriendlyDrone;
        /* 0x132AC */ public GcScannerIcon Garage;
        /* 0x133B8 */ public GcScannerIcon HexAnimation;
        /* 0x134C4 */ public GcScannerIcon MessageBeacon;
        /* 0x135D0 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x136DC */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x137E8 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x138F4 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x13A00 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x13B0C */ public GcScannerIcon MissionEnterStation;
        /* 0x13C18 */ public GcScannerIcon MonumentMarker;
        /* 0x13D24 */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x13E30 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x13F3C */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        /* 0x14048 */ public GcScannerIcon NPC;
        /* 0x14154 */ public GcScannerIcon OtherPlayerSettlement;
        /* 0x14260 */ public GcScannerIcon Pet;
        /* 0x1436C */ public GcScannerIcon PetActivity;
        /* 0x14478 */ public GcScannerIcon PetInteraction;
        /* 0x14584 */ public GcScannerIcon PetSad;
        /* 0x14690 */ public GcScannerIcon PirateRaid;
        /* 0x1479C */ public GcScannerIcon PlanetPoleNorth;
        /* 0x148A8 */ public GcScannerIcon PlanetPoleSouth;
        /* 0x149B4 */ public GcScannerIcon PlayerBase;
        /* 0x14AC0 */ public GcScannerIcon PlayerFreighter;
        /* 0x14BCC */ public GcScannerIcon PlayerSettlement;
        /* 0x14CD8 */ public GcScannerIcon PortalMarker;
        /* 0x14DE4 */ public GcScannerIcon PurchasableFrigate;
        /* 0x14EF0 */ public GcScannerIcon SettlementNPC;
        /* 0x14FFC */ public GcScannerIcon Ship;
        /* 0x15108 */ public GcScannerIcon ShipSmall;
        /* 0x15214 */ public GcScannerIcon TaggedBuilding;
        /* 0x15320 */ public GcScannerIcon TimedEvent;
        /* 0x1542C */ public GcScannerIcon Vehicle;
    }
}
