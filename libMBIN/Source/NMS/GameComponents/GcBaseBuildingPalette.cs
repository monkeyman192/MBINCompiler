using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF836E92B76CC74BF, NameHash = 0xA9F697A1)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour PrimaryColour;
        [NMS(Index = 3)]
        /* 0x10 */ public Colour QuaternaryColour;
        [NMS(Index = 1)]
        /* 0x20 */ public Colour SecondaryColour;
        [NMS(Index = 2)]
        /* 0x30 */ public Colour TernaryColour;
        [NMS(Index = 5)]
        /* 0x40 */ public NMSString0x20A Id;
        [NMS(Index = 4)]
        /* 0x60 */ public NMSString0x20A Name;
        [NMS(Index = 6)]
        /* 0x80 */ public GcSwatchColour SwatchPrimaryColour;
        [NMS(Index = 7)]
        /* 0x84 */ public GcSwatchColour SwatchSecondaryColour;
        [NMS(Index = 8)]
        /* 0x88 */ public GcSwatchColour SwatchTertiaryColour;
    }
}
