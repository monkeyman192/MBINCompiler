namespace libMBIN.Models.Structs
{
    public class GcScannerIcons : NMSTemplate       // size: 0x5BF0
    {
        /* 0x0000 */ public TkTextureResource TaggedBuilding;
        /* 0x0084 */ public TkTextureResource Ship;
        /* 0x0108 */ public TkTextureResource Vehicle;
        /* 0x018C */ public TkTextureResource Freighter;
        /* 0x0210 */ public TkTextureResource FreighterBase;
        /* 0x0294 */ public TkTextureResource PlayerFreighter;
        /* 0x0318 */ public TkTextureResource DamagedFrigate;
        /* 0x039C */ public TkTextureResource PurchasableFrigate;
        /* 0x0420 */ public TkTextureResource Expedition;
        /* 0x04A0 */ public TkTextureResource PlayerBase;
        /* 0x0528 */ public TkTextureResource EditingBase;
        /* 0x05AC */ public TkTextureResource Death;
        /* 0x0630 */ public TkTextureResource Bounty1;
        /* 0x06B4 */ public TkTextureResource Bounty2;
        /* 0x0738 */ public TkTextureResource Bounty3;
        /* 0x07BC */ public TkTextureResource Battle;
        /* 0x0840 */ public TkTextureResource ShipSmall;
        /* 0x08C4 */ public TkTextureResource DeathSmall;
        /* 0x0948 */ public TkTextureResource BountySmall;
        /* 0x09CC */ public TkTextureResource BattleSmall;
        /* 0x0A50 */ public TkTextureResource TimedEvent;
        /* 0x0AD4 */ public TkTextureResource Checkpoint;
        /* 0x0B58 */ public TkTextureResource Garage;
        /* 0x0BDC */ public TkTextureResource CircleAnimation;
        /* 0x0C60 */ public TkTextureResource HexAnimation;
        /* 0x0CE4 */ public TkTextureResource DiamondAnimation;
        /* 0x0D68 */ public TkTextureResource ArrowSmall;
        /* 0x0DEC */ public TkTextureResource ArrowLarge;

        [NMS(Size = 5)]
        /* 0x0E70 */ public TkTextureResource[] GenericIcons;

        [NMS(Size = 0x11)]
        /* 0x1104 */ public TkTextureResource[] BuildingIcons;

        [NMS(Size = 0x11)]
        /* 0x19C8 */ public TkTextureResource[] BuildingIconsBinocs;

        [NMS(Size = 0x11)]
        /* 0x228C */ public TkTextureResource[] BuildingIconsHuge;

        [NMS(Size = 0x22)]
        /* 0x2B50 */ public TkTextureResource[] ScannableIcons;

        [NMS(Size = 0x22)]
        /* 0x3CD8 */ public TkTextureResource[] ScannableIconsBinocs;

        [NMS(Size = 0x22)]
        /* 0x4E60 */ public Colour[] ScannableColours;

        /* 0x5080 */ public Colour BuildingColour;
        /* 0x5090 */ public Colour GenericColour;
        /* 0x50A0 */ public Colour RelicColour;
        /* 0x50B0 */ public Colour SignalColour;
        /* 0x50C0 */ public Colour UnknownColour;

        /* 0x50D0 */ public TkTextureResource CreatureDiscovered;
        /* 0x5154 */ public TkTextureResource CreatureUndiscovered;
        /* 0x51D8 */ public TkTextureResource CreatureUnknown;
        /* 0x525C */ public TkTextureResource MessageBeacon;
        /* 0x52E0 */ public TkTextureResource MessageBeaconSmall;
        /* 0x5364 */ public TkTextureResource BaseBuildingMarker;
        
        /* 0x53E8 */ public TkTextureResource PlanetNorthPole;
        /* 0x546C */ public TkTextureResource PlanetSouthPole;
        /* 0x54F0 */ public TkTextureResource MonumentMarker;
        /* 0x5574 */ public TkTextureResource NetworkPlayerMarker;
        /* 0x55F8 */ public TkTextureResource NetworkPlayerMarkerShip;
        /* 0x567C */ public TkTextureResource NetworkPlayerMarkerVehicle;
        
        [NMS(Size = 0x4)]
        /* 0x5700 */ public TkTextureResource[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x5910 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x5950 */ public TkTextureResource[] NetworkPlayerFreighter;
        
        /* 0x5B60 */ public TkTextureResource PortalMarker;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x5BE4 */ public byte[] EndPadding;
    }
}
