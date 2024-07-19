using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AED4B144AF77D6E, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 36, Size = 0x43, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 56, Size = 0x4)]
        /* 0x0430 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 37)]
        /* 0x0470 */ public Colour BuildingColour;
        [NMS(Index = 38)]
        /* 0x0480 */ public Colour GenericColour;
        [NMS(Index = 39)]
        /* 0x0490 */ public Colour RelicColour;
        [NMS(Index = 40)]
        /* 0x04A0 */ public Colour SignalColour;
        [NMS(Index = 41)]
        /* 0x04B0 */ public Colour UnknownColour;
        [NMS(Index = 34, Size = 0x43, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x04C0 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 35, Size = 0x43, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x1368 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 31, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2210 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 32, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x29B8 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 33, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3160 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 30, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x3908 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 54, Size = 0x4)]
        /* 0x3A58 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 55, Size = 0x4)]
        /* 0x3B38 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 57, Size = 0x4)]
        /* 0x3C18 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 66, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x3CF8 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 29)]
        /* 0x3D70 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 28)]
        /* 0x3DA8 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 47)]
        /* 0x3DE0 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 15)]
        /* 0x3E18 */ public GcScannerIcon Battle;
        [NMS(Index = 19)]
        /* 0x3E50 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 59)]
        /* 0x3E88 */ public GcScannerIcon BlackHole;
        [NMS(Index = 12)]
        /* 0x3EC0 */ public GcScannerIcon Bounty1;
        [NMS(Index = 13)]
        /* 0x3EF8 */ public GcScannerIcon Bounty2;
        [NMS(Index = 14)]
        /* 0x3F30 */ public GcScannerIcon Bounty3;
        [NMS(Index = 18)]
        /* 0x3F68 */ public GcScannerIcon BountySmall;
        [NMS(Index = 21)]
        /* 0x3FA0 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 25)]
        /* 0x3FD8 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 61)]
        /* 0x4010 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 60)]
        /* 0x4048 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 63)]
        /* 0x4080 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 42)]
        /* 0x40B8 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 64)]
        /* 0x40F0 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 72)]
        /* 0x4128 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 65)]
        /* 0x4160 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 62)]
        /* 0x4198 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 43)]
        /* 0x41D0 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 44)]
        /* 0x4208 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 6)]
        /* 0x4240 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 11)]
        /* 0x4278 */ public GcScannerIcon Death;
        [NMS(Index = 17)]
        /* 0x42B0 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 27)]
        /* 0x42E8 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 10)]
        /* 0x4320 */ public GcScannerIcon EditingBase;
        [NMS(Index = 8)]
        /* 0x4358 */ public GcScannerIcon Expedition;
        [NMS(Index = 3)]
        /* 0x4390 */ public GcScannerIcon Freighter;
        [NMS(Index = 4)]
        /* 0x43C8 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 79)]
        /* 0x4400 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 22)]
        /* 0x4438 */ public GcScannerIcon Garage;
        [NMS(Index = 26)]
        /* 0x4470 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 45)]
        /* 0x44A8 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 46)]
        /* 0x44E0 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 71)]
        /* 0x4518 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 68)]
        /* 0x4550 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 70)]
        /* 0x4588 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 67)]
        /* 0x45C0 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 69)]
        /* 0x45F8 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 50)]
        /* 0x4630 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 51)]
        /* 0x4668 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 52)]
        /* 0x46A0 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 53)]
        /* 0x46D8 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 23)]
        /* 0x4710 */ public GcScannerIcon NPC;
        [NMS(Index = 78)]
        /* 0x4748 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 74)]
        /* 0x4780 */ public GcScannerIcon Pet;
        [NMS(Index = 76)]
        /* 0x47B8 */ public GcScannerIcon PetActivity;
        [NMS(Index = 73)]
        /* 0x47F0 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 75)]
        /* 0x4828 */ public GcScannerIcon PetSad;
        [NMS(Index = 80)]
        /* 0x4860 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 48)]
        /* 0x4898 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 49)]
        /* 0x48D0 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 9)]
        /* 0x4908 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 5)]
        /* 0x4940 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 77)]
        /* 0x4978 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 58)]
        /* 0x49B0 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 7)]
        /* 0x49E8 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 24)]
        /* 0x4A20 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 1)]
        /* 0x4A58 */ public GcScannerIcon Ship;
        [NMS(Index = 16)]
        /* 0x4A90 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x4AC8 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 20)]
        /* 0x4B00 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 2)]
        /* 0x4B38 */ public GcScannerIcon Vehicle;
    }
}
