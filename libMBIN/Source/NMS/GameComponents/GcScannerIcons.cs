using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66F1E7DD3AAA747B, NameHash = 0x0392CEA8FE98D0F4)]
    public class GcScannerIcons : NMSTemplate
    {
        /* 0x00000 */ public GcScannerIcon TaggedBuilding;
        /* 0x0010C */ public GcScannerIcon Ship;
        /* 0x00218 */ public GcScannerIcon Vehicle;
        /* 0x00324 */ public GcScannerIcon Freighter;
        /* 0x00430 */ public GcScannerIcon FreighterBase;
        /* 0x0053C */ public GcScannerIcon PlayerFreighter;
        /* 0x00648 */ public GcScannerIcon DamagedFrigate;
        /* 0x00754 */ public GcScannerIcon PurchasableFrigate;
        /* 0x00860 */ public GcScannerIcon Expedition;
        /* 0x0096C */ public GcScannerIcon PlayerBase;
        /* 0x00A78 */ public GcScannerIcon EditingBase;
        /* 0x00B84 */ public GcScannerIcon Death;
        /* 0x00C90 */ public GcScannerIcon Bounty1;
        /* 0x00D9C */ public GcScannerIcon Bounty2;
        /* 0x00EA8 */ public GcScannerIcon Bounty3;
        /* 0x00FB4 */ public GcScannerIcon Battle;
        /* 0x010C0 */ public GcScannerIcon ShipSmall;
        /* 0x011CC */ public GcScannerIcon DeathSmall;
        /* 0x012D8 */ public GcScannerIcon BountySmall;
        /* 0x013E4 */ public GcScannerIcon BattleSmall;
        /* 0x014F0 */ public GcScannerIcon TimedEvent;
        /* 0x015FC */ public GcScannerIcon Checkpoint;
        /* 0x01708 */ public GcScannerIcon Garage;
        /* 0x01814 */ public GcScannerIcon NPC;
        /* 0x01920 */ public GcScannerIcon SettlementNPC;
        /* 0x01A2C */ public GcScannerIcon CircleAnimation;
        /* 0x01B38 */ public GcScannerIcon HexAnimation;
        /* 0x01C44 */ public GcScannerIcon DiamondAnimation;
        /* 0x01D50 */ public GcScannerIcon ArrowSmall;
        /* 0x01E5C */ public GcScannerIcon ArrowLarge;
        [NMS(Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x01F68 */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x21, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x025B0 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x21, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x0483C */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x21, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x06AC8 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x36, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x08D54 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x36, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0C5DC */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x36, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0FE70 */ public Colour[] ScannableColours;
        /* 0x101D0 */ public Colour BuildingColour;
        /* 0x101E0 */ public Colour GenericColour;
        /* 0x101F0 */ public Colour RelicColour;
        /* 0x10200 */ public Colour SignalColour;
        /* 0x10210 */ public Colour UnknownColour;
        /* 0x10220 */ public GcScannerIcon CreatureDiscovered;
        /* 0x1032C */ public GcScannerIcon CreatureUndiscovered;
        /* 0x10438 */ public GcScannerIcon CreatureUnknown;
        /* 0x10544 */ public GcScannerIcon MessageBeacon;
        /* 0x10650 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x1075C */ public GcScannerIcon BaseBuildingMarker;
        /* 0x10868 */ public GcScannerIcon PlanetPoleNorth;
        /* 0x10974 */ public GcScannerIcon PlanetPoleSouth;
        /* 0x10A80 */ public GcScannerIcon MonumentMarker;
        /* 0x10B8C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x10C98 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x10DA4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x10EB0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x112E0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x11710 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x11750 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x11B80 */ public GcScannerIcon PortalMarker;
        /* 0x11C8C */ public GcScannerIcon BlackHole;
        /* 0x11D98 */ public GcScannerIcon CreatureCurious;
        /* 0x11EA4 */ public GcScannerIcon CreatureAction;
        /* 0x11FB0 */ public GcScannerIcon CreatureTame;
        /* 0x120BC */ public GcScannerIcon CreatureDanger;
        /* 0x121C8 */ public GcScannerIcon CreatureFiend;
        /* 0x122D4 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x123E0 */ public TkTextureResource[] HighlightIcons;
        /* 0x12674 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x12780 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x1288C */ public GcScannerIcon MissionEnterStation;
        /* 0x12998 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x12AA4 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x12BB0 */ public GcScannerIcon CreatureInteraction;
        /* 0x12CBC */ public GcScannerIcon PetInteraction;
        /* 0x12DC8 */ public GcScannerIcon Pet;
        /* 0x12ED4 */ public GcScannerIcon PetSad;
        /* 0x12FE0 */ public GcScannerIcon PetActivity;
        /* 0x130EC */ public GcScannerIcon PlayerSettlement;
        /* 0x131F8 */ public GcScannerIcon OtherPlayerSettlement;
        /* 0x13304 */ public GcScannerIcon FriendlyDrone;
        /* 0x13410 */ public GcScannerIcon PirateRaid;
        /* 0x1351C */ public GcScannerIcon FuelAsteroid;
    }
}
