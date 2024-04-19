namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DFAC1F6DF6F3F6A, NameHash = 0xB66F8D60603D1092)]
    public class GcPaletteData : NMSTemplate
    {
        [NMS(Size = 0x40)]
        /* 0x000 */ public Colour[] Colours;
        // size: 0x6
        public enum NumColoursEnum : uint {
            Inactive,
            _1,
            _4,
            _8,
            _16,
            All,
        }
        /* 0x400 */ public NumColoursEnum NumColours;
    }
}
