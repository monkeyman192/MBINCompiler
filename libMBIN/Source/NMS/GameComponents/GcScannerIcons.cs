using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x12540, GUID = 0xAAF97EB9DB2E77B9, NameHash = 0x392CEA8FE98D0F4)]
    public class GcScannerIcons : NMSTemplate
    {
        /* 0x0000 */ public GcScannerIcon TaggedBuilding;
        /* 0x010C */ public GcScannerIcon Ship;
        /* 0x0218 */ public GcScannerIcon Vehicle;
        /* 0x0324 */ public GcScannerIcon Freighter;
        /* 0x0430 */ public GcScannerIcon FreighterBase;
        /* 0x053C */ public GcScannerIcon PlayerFreighter;
        /* 0x0648 */ public GcScannerIcon DamagedFrigate;
        /* 0x0754 */ public GcScannerIcon PurchasableFrigate;
        /* 0x0860 */ public GcScannerIcon Expedition;
        /* 0x096C */ public GcScannerIcon PlayerBase;
        /* 0x0A78 */ public GcScannerIcon EditingBase;
        /* 0x0B84 */ public GcScannerIcon Death;
        /* 0x0C90 */ public GcScannerIcon Bounty1;
        /* 0x0D9C */ public GcScannerIcon Bounty2;
        /* 0x0EA8 */ public GcScannerIcon Bounty3;
        /* 0x0FB4 */ public GcScannerIcon Battle;
        /* 0x10C0 */ public GcScannerIcon ShipSmall;
        /* 0x11CC */ public GcScannerIcon DeathSmall;
        /* 0x12D8 */ public GcScannerIcon BountySmall;
        /* 0x13E4 */ public GcScannerIcon BattleSmall;
        /* 0x14F0 */ public GcScannerIcon TimedEvent;
        /* 0x15FC */ public GcScannerIcon Checkpoint;
        /* 0x1700 */ public GcScannerIcon Garage;
        /* 0x1814 */ public GcScannerIcon NPC;
        /* 0x1920 */ public GcScannerIcon CircleAnimation;
        /* 0x1A2C */ public GcScannerIcon HexAnimation;
        /* 0x1B38 */ public GcScannerIcon DiamondAnimation;
        /* 0x1C44 */ public GcScannerIcon ArrowSmall;
        /* 0x1D50 */ public GcScannerIcon ArrowLarge;
        [NMS(Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x1E5C */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x1F, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x24A4 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x1F, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x4518 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x1F, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x658C */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x34, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x8600 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x34, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xBC70 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x34, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xF2E0 */ public Colour[] ScannableColours;
        /* 0xF620 */ public Colour BuildingColour;
        /* 0xF630 */ public Colour GenericColour;
        /* 0xF640 */ public Colour RelicColour;
        /* 0xF650 */ public Colour SignalColour;
        /* 0xF660 */ public Colour UnknownColour;
        /* 0xF670 */ public GcScannerIcon CreatureDiscovered;
        /* 0xF77C */ public GcScannerIcon CreatureUndiscovered;
        /* 0xF888 */ public GcScannerIcon CreatureUnknown;
        /* 0xF994 */ public GcScannerIcon MessageBeacon;
        /* 0xFAA0 */ public GcScannerIcon MessageBeaconSmall;
        /* 0xFBAC */ public GcScannerIcon BaseBuildingMarker;
        /* 0xFCB8 */ public GcScannerIcon PlanetPoleNorth;
        /* 0xFDC4 */ public GcScannerIcon PlanetPoleSouth;
        /* 0xFED0 */ public GcScannerIcon MonumentMarker;
        /* 0xFFDC */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x100E8 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x101F4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x10300 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x10730 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x10B60 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x10BA0 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x10FD0 */ public GcScannerIcon PortalMarker;
        /* 0x110DC */ public GcScannerIcon BlackHole;
        /* 0x111E8 */ public GcScannerIcon CreatureCurious;
        /* 0x112F4 */ public GcScannerIcon CreatureAction;
        /* 0x11400 */ public GcScannerIcon CreatureTame;
        /* 0x1150C */ public GcScannerIcon CreatureDanger;
        /* 0x11618 */ public GcScannerIcon CreatureFiend;
        /* 0x11724 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x11830 */ public TkTextureResource[] HighlightIcons;
        /* 0x11AC4 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x11BD0 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x11CDC */ public GcScannerIcon MissionEnterStation;
        /* 0x11DE8 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x11EF4 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x12000 */ public GcScannerIcon CreatureInteraction;
        /* 0x1210C */ public GcScannerIcon PetInteraction;
        /* 0x12218 */ public GcScannerIcon Pet;
        /* 0x12324 */ public GcScannerIcon PetSad;
        /* 0x12430 */ public GcScannerIcon PetActivity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1253C */ public byte[] EndPadding;
    }
}
