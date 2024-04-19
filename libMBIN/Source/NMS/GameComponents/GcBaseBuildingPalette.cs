namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC9B662A4D061ACE, NameHash = 0xB499CC97C0515963)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour QuaternaryColour;
        /* 0x20 */ public Colour SecondaryColour;
        /* 0x30 */ public Colour TernaryColour;
        /* 0x40 */ public NMSString0x20A Id;
        /* 0x60 */ public NMSString0x20A Name;
        // size: 0x4
        public enum SwatchPrimaryColourEnum : uint {
            Primary,
            Secondary,
            Ternary,
            Quaternary,
        }
        /* 0x80 */ public SwatchPrimaryColourEnum SwatchPrimaryColour;
        // size: 0x4
        public enum SwatchSecondaryColourEnum : uint {
            Primary,
            Secondary,
            Ternary,
            Quaternary,
        }
        /* 0x84 */ public SwatchSecondaryColourEnum SwatchSecondaryColour;
    }
}
