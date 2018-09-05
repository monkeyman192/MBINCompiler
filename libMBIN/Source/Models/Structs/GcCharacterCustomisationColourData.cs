namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        public TkPaletteTexture Palette;
        public Colour Colour;
    }
}
