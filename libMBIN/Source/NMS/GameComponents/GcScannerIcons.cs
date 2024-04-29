using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEADFF0A1A1E02C4, NameHash = 0x392CEA8FE98D0F4)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 36, Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x00000 */ public Colour[] ScannableColours;
        [NMS(Index = 56, Size = 0x4)]
        /* 0x00420 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 37)]
        /* 0x00460 */ public Colour BuildingColour;
        [NMS(Index = 38)]
        /* 0x00470 */ public Colour GenericColour;
        [NMS(Index = 39)]
        /* 0x00480 */ public Colour RelicColour;
        [NMS(Index = 40)]
        /* 0x00490 */ public Colour SignalColour;
        [NMS(Index = 41)]
        /* 0x004A0 */ public Colour UnknownColour;
        [NMS(Index = 34, Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x004B0 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 35, Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x049C8 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 31, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x08EE0 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 32, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x0B384 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 33, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x0D828 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 30, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x0FCCC */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 54, Size = 0x4)]
        /* 0x10314 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 55, Size = 0x4)]
        /* 0x10744 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 57, Size = 0x4)]
        /* 0x10B74 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 66, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x10FA4 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 29)]
        /* 0x11238 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 28)]
        /* 0x11344 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 47)]
        /* 0x11450 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 15)]
        /* 0x1155C */ public GcScannerIcon Battle;
        [NMS(Index = 19)]
        /* 0x11668 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 59)]
        /* 0x11774 */ public GcScannerIcon BlackHole;
        [NMS(Index = 12)]
        /* 0x11880 */ public GcScannerIcon Bounty1;
        [NMS(Index = 13)]
        /* 0x1198C */ public GcScannerIcon Bounty2;
        [NMS(Index = 14)]
        /* 0x11A98 */ public GcScannerIcon Bounty3;
        [NMS(Index = 18)]
        /* 0x11BA4 */ public GcScannerIcon BountySmall;
        [NMS(Index = 21)]
        /* 0x11CB0 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 25)]
        /* 0x11DBC */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 61)]
        /* 0x11EC8 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 60)]
        /* 0x11FD4 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 63)]
        /* 0x120E0 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 42)]
        /* 0x121EC */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 64)]
        /* 0x122F8 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 72)]
        /* 0x12404 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 65)]
        /* 0x12510 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 62)]
        /* 0x1261C */ public GcScannerIcon CreatureTame;
        [NMS(Index = 43)]
        /* 0x12728 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 44)]
        /* 0x12834 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 6)]
        /* 0x12940 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 11)]
        /* 0x12A4C */ public GcScannerIcon Death;
        [NMS(Index = 17)]
        /* 0x12B58 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 27)]
        /* 0x12C64 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 10)]
        /* 0x12D70 */ public GcScannerIcon EditingBase;
        [NMS(Index = 8)]
        /* 0x12E7C */ public GcScannerIcon Expedition;
        [NMS(Index = 3)]
        /* 0x12F88 */ public GcScannerIcon Freighter;
        [NMS(Index = 4)]
        /* 0x13094 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 79)]
        /* 0x131A0 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 22)]
        /* 0x132AC */ public GcScannerIcon Garage;
        [NMS(Index = 26)]
        /* 0x133B8 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 45)]
        /* 0x134C4 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 46)]
        /* 0x135D0 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 71)]
        /* 0x136DC */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 68)]
        /* 0x137E8 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 70)]
        /* 0x138F4 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 67)]
        /* 0x13A00 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 69)]
        /* 0x13B0C */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 50)]
        /* 0x13C18 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 51)]
        /* 0x13D24 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 52)]
        /* 0x13E30 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 53)]
        /* 0x13F3C */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 23)]
        /* 0x14048 */ public GcScannerIcon NPC;
        [NMS(Index = 78)]
        /* 0x14154 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 74)]
        /* 0x14260 */ public GcScannerIcon Pet;
        [NMS(Index = 76)]
        /* 0x1436C */ public GcScannerIcon PetActivity;
        [NMS(Index = 73)]
        /* 0x14478 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 75)]
        /* 0x14584 */ public GcScannerIcon PetSad;
        [NMS(Index = 80)]
        /* 0x14690 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 48)]
        /* 0x1479C */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 49)]
        /* 0x148A8 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 9)]
        /* 0x149B4 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 5)]
        /* 0x14AC0 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 77)]
        /* 0x14BCC */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 58)]
        /* 0x14CD8 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 7)]
        /* 0x14DE4 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 24)]
        /* 0x14EF0 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 1)]
        /* 0x14FFC */ public GcScannerIcon Ship;
        [NMS(Index = 16)]
        /* 0x15108 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x15214 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 20)]
        /* 0x15320 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 2)]
        /* 0x1542C */ public GcScannerIcon Vehicle;
    }
}
