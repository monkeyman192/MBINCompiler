using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xDEA0, GUID = 0xAA67829A2A9BCC87, NameHash = 0x392CEA8FE98D0F4)]
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

        [NMS(Size = 6)]
        /* 0x1E5C */ public GcScannerIcon[] GenericIcons;

        [NMS(Size = 0x12)]
        /* 0x24A4 */ public GcScannerIcon[] BuildingIcons;

        [NMS(Size = 0x12)]
        /* 0x377C */ public GcScannerIcon[] BuildingIconsBinocs;

        [NMS(Size = 0x12)]
        /* 0x4A54 */ public GcScannerIcon[] BuildingIconsHuge;

        [NMS(Size = 0x2B, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x5D2C */ public GcScannerIcon[] ScannableIcons;

        [NMS(Size = 0x2B, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x8A30 */ public GcScannerIcon[] ScannableIconsBinocs;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0xB734 */ public byte[] PaddingB734;

        [NMS(Size = 0x2B, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xB740 */ public Colour[] ScannableColours;

        /* 0xB9F0 */ public Colour BuildingColour;
        /* 0xBA00 */ public Colour GenericColour;
        /* 0xBA10 */ public Colour RelicColour;
        /* 0xBA20 */ public Colour SignalColour;
        /* 0xBA30 */ public Colour UnknownColour;

        /* 0xBA40 */ public GcScannerIcon CreatureDiscovered;
        /* 0xBB4C */ public GcScannerIcon CreatureUndiscovered;
        /* 0xBC58 */ public GcScannerIcon CreatureUnknown;
        /* 0xBD64 */ public GcScannerIcon MessageBeacon;
        /* 0xBE70 */ public GcScannerIcon MessageBeaconSmall;
        /* 0xBF7C */ public GcScannerIcon BaseBuildingMarker;
        /* 0xC088 */ public GcScannerIcon PlanetNorthPole;
        /* 0xC194 */ public GcScannerIcon PlanetSouthPole;
        /* 0xC2A0 */ public GcScannerIcon MonumentMarker;
        /* 0xC3AC */ public GcScannerIcon NetworkPlayerMarker;
        /* 0xC4B8 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0xC5C4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        
        [NMS(Size = 0x4)]
        /* 0xC6D0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0xCB00 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0xCF30 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0xCF70 */ public GcScannerIcon[] NetworkPlayerFreighter;
        
        /* 0xD3A0 */ public GcScannerIcon PortalMarker;
        /* 0xD4AC */ public GcScannerIcon BlackHole;
        /* 0xD5B8 */ public GcScannerIcon CreatureCurious;
        /* 0xD6C4 */ public GcScannerIcon CreatureAction;
        /* 0xD7D0 */ public GcScannerIcon CreatureTame;
        /* 0xD8DC */ public GcScannerIcon CreatureDanger;
        /* 0xD9E8 */ public GcScannerIcon CreatureFiend;
        /* 0xDAF4 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0xDC00 */ public TkTextureResource[] HighlighIcons;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0xDE94 */ public byte[] EndPadding;
    }
}
