using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC9851B70975C4F6, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 44, Size = 0x57, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 66, Size = 0x4)]
        /* 0x0570 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 45)]
        /* 0x05B0 */ public Colour BuildingColour;
        [NMS(Index = 46)]
        /* 0x05C0 */ public Colour GenericColour;
        [NMS(Index = 47)]
        /* 0x05D0 */ public Colour RelicColour;
        [NMS(Index = 48)]
        /* 0x05E0 */ public Colour SignalColour;
        [NMS(Index = 49)]
        /* 0x05F0 */ public Colour UnknownColour;
        [NMS(Index = 42, Size = 0x57, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0600 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 43, Size = 0x57, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x1908 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 38, Size = 0x26, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2C10 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 39, Size = 0x26, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3460 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 40, Size = 0x26, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3CB0 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 41, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x4500 */ public GcScannerIcon[] SpacePoiIcons;
        [NMS(Index = 5, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4810 */ public GcScannerIcon[] Vehicles;
        [NMS(Index = 37, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x4998 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 67, Size = 0x4)]
        /* 0x4AE8 */ public GcScannerIcon[] NetworkFSPlayerCorvetteTeleporter;
        [NMS(Index = 64, Size = 0x4)]
        /* 0x4BC8 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 65, Size = 0x4)]
        /* 0x4CA8 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 68, Size = 0x4)]
        /* 0x4D88 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 77, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x4E68 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 36)]
        /* 0x4EE0 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 35)]
        /* 0x4F18 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 55)]
        /* 0x4F50 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 20)]
        /* 0x4F88 */ public GcScannerIcon Battle;
        [NMS(Index = 25)]
        /* 0x4FC0 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 70)]
        /* 0x4FF8 */ public GcScannerIcon BlackHole;
        [NMS(Index = 17)]
        /* 0x5030 */ public GcScannerIcon Bounty1;
        [NMS(Index = 18)]
        /* 0x5068 */ public GcScannerIcon Bounty2;
        [NMS(Index = 19)]
        /* 0x50A0 */ public GcScannerIcon Bounty3;
        [NMS(Index = 24)]
        /* 0x50D8 */ public GcScannerIcon BountySmall;
        [NMS(Index = 27)]
        /* 0x5110 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 32)]
        /* 0x5148 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 3)]
        /* 0x5180 */ public GcScannerIcon Corvette;
        [NMS(Index = 31)]
        /* 0x51B8 */ public GcScannerIcon CorvetteDeployedTeleporter;
        [NMS(Index = 72)]
        /* 0x51F0 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 71)]
        /* 0x5228 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 74)]
        /* 0x5260 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 50)]
        /* 0x5298 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 75)]
        /* 0x52D0 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 83)]
        /* 0x5308 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 76)]
        /* 0x5340 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 73)]
        /* 0x5378 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 51)]
        /* 0x53B0 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 52)]
        /* 0x53E8 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 9)]
        /* 0x5420 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 16)]
        /* 0x5458 */ public GcScannerIcon Death;
        [NMS(Index = 23)]
        /* 0x5490 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 93)]
        /* 0x54C8 */ public GcScannerIcon DefaultSpacePoi;
        [NMS(Index = 34)]
        /* 0x5500 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 13)]
        /* 0x5538 */ public GcScannerIcon EditingBase;
        [NMS(Index = 15)]
        /* 0x5570 */ public GcScannerIcon EditingSpaceBase;
        [NMS(Index = 11)]
        /* 0x55A8 */ public GcScannerIcon Expedition;
        [NMS(Index = 6)]
        /* 0x55E0 */ public GcScannerIcon Freighter;
        [NMS(Index = 7)]
        /* 0x5618 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 90)]
        /* 0x5650 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 28)]
        /* 0x5688 */ public GcScannerIcon Garage;
        [NMS(Index = 33)]
        /* 0x56C0 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 53)]
        /* 0x56F8 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 54)]
        /* 0x5730 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 82)]
        /* 0x5768 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 79)]
        /* 0x57A0 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 81)]
        /* 0x57D8 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 78)]
        /* 0x5810 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 80)]
        /* 0x5848 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 60)]
        /* 0x5880 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 61)]
        /* 0x58B8 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 62)]
        /* 0x58F0 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 63)]
        /* 0x5928 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 29)]
        /* 0x5960 */ public GcScannerIcon NPC;
        [NMS(Index = 89)]
        /* 0x5998 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 85)]
        /* 0x59D0 */ public GcScannerIcon Pet;
        [NMS(Index = 87)]
        /* 0x5A08 */ public GcScannerIcon PetActivity;
        [NMS(Index = 84)]
        /* 0x5A40 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 86)]
        /* 0x5A78 */ public GcScannerIcon PetSad;
        [NMS(Index = 91)]
        /* 0x5AB0 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 58)]
        /* 0x5AE8 */ public GcScannerIcon PlanetPoleEast;
        [NMS(Index = 56)]
        /* 0x5B20 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 57)]
        /* 0x5B58 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 59)]
        /* 0x5B90 */ public GcScannerIcon PlanetPoleWest;
        [NMS(Index = 12)]
        /* 0x5BC8 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 8)]
        /* 0x5C00 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 88)]
        /* 0x5C38 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 14)]
        /* 0x5C70 */ public GcScannerIcon PlayerSpaceBase;
        [NMS(Index = 69)]
        /* 0x5CA8 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 10)]
        /* 0x5CE0 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 30)]
        /* 0x5D18 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 2)]
        /* 0x5D50 */ public GcScannerIcon Ship;
        [NMS(Index = 22)]
        /* 0x5D88 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 21)]
        /* 0x5DC0 */ public GcScannerIcon SwarmHiveBattle;
        [NMS(Index = 0)]
        /* 0x5DF8 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 1)]
        /* 0x5E30 */ public GcScannerIcon TaggedPlanet;
        [NMS(Index = 26)]
        /* 0x5E68 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 92)]
        /* 0x5EA0 */ public GcScannerIcon UndiscoveredSpacePoi;
        [NMS(Index = 4)]
        /* 0x5ED8 */ public GcScannerIcon VehicleGeneric;
    }
}
