using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC2447DC78FED21E, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 44, Size = 0x5A, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 66, Size = 0x4)]
        /* 0x05A0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 45)]
        /* 0x05E0 */ public Colour BuildingColour;
        [NMS(Index = 46)]
        /* 0x05F0 */ public Colour GenericColour;
        [NMS(Index = 47)]
        /* 0x0600 */ public Colour RelicColour;
        [NMS(Index = 48)]
        /* 0x0610 */ public Colour SignalColour;
        [NMS(Index = 49)]
        /* 0x0620 */ public Colour UnknownColour;
        [NMS(Index = 42, Size = 0x5A, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0630 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 43, Size = 0x5A, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x19E0 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 38, Size = 0x26, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2D90 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 39, Size = 0x26, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x35E0 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 40, Size = 0x26, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3E30 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 41, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x4680 */ public GcScannerIcon[] SpacePoiIcons;
        [NMS(Index = 5, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4990 */ public GcScannerIcon[] Vehicles;
        [NMS(Index = 37, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x4B18 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 67, Size = 0x4)]
        /* 0x4C68 */ public GcScannerIcon[] NetworkFSPlayerCorvetteTeleporter;
        [NMS(Index = 64, Size = 0x4)]
        /* 0x4D48 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 65, Size = 0x4)]
        /* 0x4E28 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 68, Size = 0x4)]
        /* 0x4F08 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 77, Size = 0x6, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x4FE8 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 36)]
        /* 0x5078 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 35)]
        /* 0x50B0 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 55)]
        /* 0x50E8 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 20)]
        /* 0x5120 */ public GcScannerIcon Battle;
        [NMS(Index = 25)]
        /* 0x5158 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 70)]
        /* 0x5190 */ public GcScannerIcon BlackHole;
        [NMS(Index = 17)]
        /* 0x51C8 */ public GcScannerIcon Bounty1;
        [NMS(Index = 18)]
        /* 0x5200 */ public GcScannerIcon Bounty2;
        [NMS(Index = 19)]
        /* 0x5238 */ public GcScannerIcon Bounty3;
        [NMS(Index = 24)]
        /* 0x5270 */ public GcScannerIcon BountySmall;
        [NMS(Index = 27)]
        /* 0x52A8 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 32)]
        /* 0x52E0 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 3)]
        /* 0x5318 */ public GcScannerIcon Corvette;
        [NMS(Index = 31)]
        /* 0x5350 */ public GcScannerIcon CorvetteDeployedTeleporter;
        [NMS(Index = 72)]
        /* 0x5388 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 71)]
        /* 0x53C0 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 74)]
        /* 0x53F8 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 50)]
        /* 0x5430 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 75)]
        /* 0x5468 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 83)]
        /* 0x54A0 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 76)]
        /* 0x54D8 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 73)]
        /* 0x5510 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 51)]
        /* 0x5548 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 52)]
        /* 0x5580 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 9)]
        /* 0x55B8 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 16)]
        /* 0x55F0 */ public GcScannerIcon Death;
        [NMS(Index = 23)]
        /* 0x5628 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 93)]
        /* 0x5660 */ public GcScannerIcon DefaultSpacePoi;
        [NMS(Index = 34)]
        /* 0x5698 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 13)]
        /* 0x56D0 */ public GcScannerIcon EditingBase;
        [NMS(Index = 15)]
        /* 0x5708 */ public GcScannerIcon EditingSpaceBase;
        [NMS(Index = 11)]
        /* 0x5740 */ public GcScannerIcon Expedition;
        [NMS(Index = 6)]
        /* 0x5778 */ public GcScannerIcon Freighter;
        [NMS(Index = 7)]
        /* 0x57B0 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 90)]
        /* 0x57E8 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 28)]
        /* 0x5820 */ public GcScannerIcon Garage;
        [NMS(Index = 33)]
        /* 0x5858 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 53)]
        /* 0x5890 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 54)]
        /* 0x58C8 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 82)]
        /* 0x5900 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 79)]
        /* 0x5938 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 81)]
        /* 0x5970 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 78)]
        /* 0x59A8 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 80)]
        /* 0x59E0 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 60)]
        /* 0x5A18 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 94)]
        /* 0x5A50 */ public GcScannerIcon NeighbouringSystem;
        [NMS(Index = 61)]
        /* 0x5A88 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 62)]
        /* 0x5AC0 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 63)]
        /* 0x5AF8 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 29)]
        /* 0x5B30 */ public GcScannerIcon NPC;
        [NMS(Index = 89)]
        /* 0x5B68 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 85)]
        /* 0x5BA0 */ public GcScannerIcon Pet;
        [NMS(Index = 87)]
        /* 0x5BD8 */ public GcScannerIcon PetActivity;
        [NMS(Index = 84)]
        /* 0x5C10 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 86)]
        /* 0x5C48 */ public GcScannerIcon PetSad;
        [NMS(Index = 91)]
        /* 0x5C80 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 58)]
        /* 0x5CB8 */ public GcScannerIcon PlanetPoleEast;
        [NMS(Index = 56)]
        /* 0x5CF0 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 57)]
        /* 0x5D28 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 59)]
        /* 0x5D60 */ public GcScannerIcon PlanetPoleWest;
        [NMS(Index = 12)]
        /* 0x5D98 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 8)]
        /* 0x5DD0 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 88)]
        /* 0x5E08 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 14)]
        /* 0x5E40 */ public GcScannerIcon PlayerSpaceBase;
        [NMS(Index = 69)]
        /* 0x5E78 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 10)]
        /* 0x5EB0 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 30)]
        /* 0x5EE8 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 2)]
        /* 0x5F20 */ public GcScannerIcon Ship;
        [NMS(Index = 22)]
        /* 0x5F58 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 21)]
        /* 0x5F90 */ public GcScannerIcon SwarmHiveBattle;
        [NMS(Index = 0)]
        /* 0x5FC8 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 1)]
        /* 0x6000 */ public GcScannerIcon TaggedPlanet;
        [NMS(Index = 26)]
        /* 0x6038 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 92)]
        /* 0x6070 */ public GcScannerIcon UndiscoveredSpacePoi;
        [NMS(Index = 4)]
        /* 0x60A8 */ public GcScannerIcon VehicleGeneric;
    }
}
