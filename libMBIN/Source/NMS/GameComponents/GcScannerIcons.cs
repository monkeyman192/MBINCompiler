using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcScannerIcons : NMSTemplate
    {
        public TkTextureResource TaggedBuilding;
        public TkTextureResource Ship;
        public TkTextureResource Death;
        public TkTextureResource Bounty1;
        public TkTextureResource Bounty2;
        public TkTextureResource Bounty3;
        public TkTextureResource Battle;
        public TkTextureResource ShipSmall;
        public TkTextureResource DeathSmall;
        public TkTextureResource BountySmall;
        public TkTextureResource BattleSmall;
        public TkTextureResource CircleAnimation;
        public TkTextureResource HexAnimation;
        public TkTextureResource ArrowSmall;
        public TkTextureResource ArrowLarge;

        [NMS(Size = 5)]
        public TkTextureResource[] GenericIcons;

        [NMS(Size = 0xF)]
        public TkTextureResource[] BuildingIcons;

        [NMS(Size = 0xF)]
        public TkTextureResource[] BuildingIconsLarge;

        [NMS(Size = 0xF)]
        public TkTextureResource[] BuildingIconsInactive;

        [NMS(Size = 0xF)]
        public TkTextureResource[] BuildingIconsInactiveLarge;

        [NMS(Size = 0xF)]
        public TkTextureResource[] BuildingIconsHuge;

        [NMS(Size = 0xC)]
        public TkTextureResource[] ScannableIcons;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding372C;

        [NMS(Size = 0xC)]
        public Colour[] ScannableColours;

        public Colour BuildingColour;
        public Colour GenericColour;
        public Colour InactiveColour;
        public Colour RelicColour;
        public Colour SignalColour;
        public Colour UnknownColour;

        public TkTextureResource CreatureDiscovered;
        public TkTextureResource CreatureUndiscovered;
        public TkTextureResource CreatureUnknown;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding39DC;
    }
}
