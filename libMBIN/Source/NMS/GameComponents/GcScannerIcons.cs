using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1C54C42833D31DA9, NameHash = 0xF873D7AD)]
    public class GcScannerIcons : NMSTemplate
    {
        [NMS(Index = 36, Size = 0x45, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0000 */ public Colour[] ScannableColours;
        [NMS(Index = 56, Size = 0x4)]
        /* 0x0450 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Index = 37)]
        /* 0x0490 */ public Colour BuildingColour;
        [NMS(Index = 38)]
        /* 0x04A0 */ public Colour GenericColour;
        [NMS(Index = 39)]
        /* 0x04B0 */ public Colour RelicColour;
        [NMS(Index = 40)]
        /* 0x04C0 */ public Colour SignalColour;
        [NMS(Index = 41)]
        /* 0x04D0 */ public Colour UnknownColour;
        [NMS(Index = 34, Size = 0x45, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x04E0 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Index = 35, Size = 0x45, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x13F8 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Index = 31, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2310 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Index = 32, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x2AB8 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Index = 33, Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x3260 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Index = 30, Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x3A08 */ public GcScannerIcon[] GenericIcons;
        [NMS(Index = 54, Size = 0x4)]
        /* 0x3B58 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Index = 55, Size = 0x4)]
        /* 0x3C38 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Index = 57, Size = 0x4)]
        /* 0x3D18 */ public GcScannerIcon[] NetworkPlayerFreighter;
        [NMS(Index = 66, Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x3DF8 */ public TkTextureResource[] HighlightIcons;
        [NMS(Index = 29)]
        /* 0x3E70 */ public GcScannerIcon ArrowLarge;
        [NMS(Index = 28)]
        /* 0x3EA8 */ public GcScannerIcon ArrowSmall;
        [NMS(Index = 47)]
        /* 0x3EE0 */ public GcScannerIcon BaseBuildingMarker;
        [NMS(Index = 15)]
        /* 0x3F18 */ public GcScannerIcon Battle;
        [NMS(Index = 19)]
        /* 0x3F50 */ public GcScannerIcon BattleSmall;
        [NMS(Index = 59)]
        /* 0x3F88 */ public GcScannerIcon BlackHole;
        [NMS(Index = 12)]
        /* 0x3FC0 */ public GcScannerIcon Bounty1;
        [NMS(Index = 13)]
        /* 0x3FF8 */ public GcScannerIcon Bounty2;
        [NMS(Index = 14)]
        /* 0x4030 */ public GcScannerIcon Bounty3;
        [NMS(Index = 18)]
        /* 0x4068 */ public GcScannerIcon BountySmall;
        [NMS(Index = 21)]
        /* 0x40A0 */ public GcScannerIcon Checkpoint;
        [NMS(Index = 25)]
        /* 0x40D8 */ public GcScannerIcon CircleAnimation;
        [NMS(Index = 61)]
        /* 0x4110 */ public GcScannerIcon CreatureAction;
        [NMS(Index = 60)]
        /* 0x4148 */ public GcScannerIcon CreatureCurious;
        [NMS(Index = 63)]
        /* 0x4180 */ public GcScannerIcon CreatureDanger;
        [NMS(Index = 42)]
        /* 0x41B8 */ public GcScannerIcon CreatureDiscovered;
        [NMS(Index = 64)]
        /* 0x41F0 */ public GcScannerIcon CreatureFiend;
        [NMS(Index = 72)]
        /* 0x4228 */ public GcScannerIcon CreatureInteraction;
        [NMS(Index = 65)]
        /* 0x4260 */ public GcScannerIcon CreatureMilk;
        [NMS(Index = 62)]
        /* 0x4298 */ public GcScannerIcon CreatureTame;
        [NMS(Index = 43)]
        /* 0x42D0 */ public GcScannerIcon CreatureUndiscovered;
        [NMS(Index = 44)]
        /* 0x4308 */ public GcScannerIcon CreatureUnknown;
        [NMS(Index = 6)]
        /* 0x4340 */ public GcScannerIcon DamagedFrigate;
        [NMS(Index = 11)]
        /* 0x4378 */ public GcScannerIcon Death;
        [NMS(Index = 17)]
        /* 0x43B0 */ public GcScannerIcon DeathSmall;
        [NMS(Index = 27)]
        /* 0x43E8 */ public GcScannerIcon DiamondAnimation;
        [NMS(Index = 10)]
        /* 0x4420 */ public GcScannerIcon EditingBase;
        [NMS(Index = 8)]
        /* 0x4458 */ public GcScannerIcon Expedition;
        [NMS(Index = 3)]
        /* 0x4490 */ public GcScannerIcon Freighter;
        [NMS(Index = 4)]
        /* 0x44C8 */ public GcScannerIcon FreighterBase;
        [NMS(Index = 79)]
        /* 0x4500 */ public GcScannerIcon FriendlyDrone;
        [NMS(Index = 22)]
        /* 0x4538 */ public GcScannerIcon Garage;
        [NMS(Index = 26)]
        /* 0x4570 */ public GcScannerIcon HexAnimation;
        [NMS(Index = 45)]
        /* 0x45A8 */ public GcScannerIcon MessageBeacon;
        [NMS(Index = 46)]
        /* 0x45E0 */ public GcScannerIcon MessageBeaconSmall;
        [NMS(Index = 71)]
        /* 0x4618 */ public GcScannerIcon MissionAbandonedFreighter;
        [NMS(Index = 68)]
        /* 0x4650 */ public GcScannerIcon MissionEnterBuilding;
        [NMS(Index = 70)]
        /* 0x4688 */ public GcScannerIcon MissionEnterFreighter;
        [NMS(Index = 67)]
        /* 0x46C0 */ public GcScannerIcon MissionEnterOrbit;
        [NMS(Index = 69)]
        /* 0x46F8 */ public GcScannerIcon MissionEnterStation;
        [NMS(Index = 50)]
        /* 0x4730 */ public GcScannerIcon MonumentMarker;
        [NMS(Index = 51)]
        /* 0x4768 */ public GcScannerIcon NetworkPlayerMarker;
        [NMS(Index = 52)]
        /* 0x47A0 */ public GcScannerIcon NetworkPlayerMarkerShip;
        [NMS(Index = 53)]
        /* 0x47D8 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Index = 23)]
        /* 0x4810 */ public GcScannerIcon NPC;
        [NMS(Index = 78)]
        /* 0x4848 */ public GcScannerIcon OtherPlayerSettlement;
        [NMS(Index = 74)]
        /* 0x4880 */ public GcScannerIcon Pet;
        [NMS(Index = 76)]
        /* 0x48B8 */ public GcScannerIcon PetActivity;
        [NMS(Index = 73)]
        /* 0x48F0 */ public GcScannerIcon PetInteraction;
        [NMS(Index = 75)]
        /* 0x4928 */ public GcScannerIcon PetSad;
        [NMS(Index = 80)]
        /* 0x4960 */ public GcScannerIcon PirateRaid;
        [NMS(Index = 48)]
        /* 0x4998 */ public GcScannerIcon PlanetPoleNorth;
        [NMS(Index = 49)]
        /* 0x49D0 */ public GcScannerIcon PlanetPoleSouth;
        [NMS(Index = 9)]
        /* 0x4A08 */ public GcScannerIcon PlayerBase;
        [NMS(Index = 5)]
        /* 0x4A40 */ public GcScannerIcon PlayerFreighter;
        [NMS(Index = 77)]
        /* 0x4A78 */ public GcScannerIcon PlayerSettlement;
        [NMS(Index = 58)]
        /* 0x4AB0 */ public GcScannerIcon PortalMarker;
        [NMS(Index = 7)]
        /* 0x4AE8 */ public GcScannerIcon PurchasableFrigate;
        [NMS(Index = 24)]
        /* 0x4B20 */ public GcScannerIcon SettlementNPC;
        [NMS(Index = 1)]
        /* 0x4B58 */ public GcScannerIcon Ship;
        [NMS(Index = 16)]
        /* 0x4B90 */ public GcScannerIcon ShipSmall;
        [NMS(Index = 0)]
        /* 0x4BC8 */ public GcScannerIcon TaggedBuilding;
        [NMS(Index = 20)]
        /* 0x4C00 */ public GcScannerIcon TimedEvent;
        [NMS(Index = 2)]
        /* 0x4C38 */ public GcScannerIcon Vehicle;
    }
}
