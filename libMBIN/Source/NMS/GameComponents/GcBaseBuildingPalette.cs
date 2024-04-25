namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC9B662A4D061ACE, NameHash = 0xB499CC97C0515963)]
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
        // size: 0x4
        public enum SwatchPrimaryColourEnum : uint {
            Primary,
            Secondary,
            Ternary,
            Quaternary,
        }
        [NMS(Index = 6)]
        /* 0x80 */ public SwatchPrimaryColourEnum SwatchPrimaryColour;
        // size: 0x4
        public enum SwatchSecondaryColourEnum : uint {
            Primary,
            Secondary,
            Ternary,
            Quaternary,
        }
        [NMS(Index = 7)]
        /* 0x84 */ public SwatchSecondaryColourEnum SwatchSecondaryColour;
    }
}
