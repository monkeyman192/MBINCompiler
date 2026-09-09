using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5825E50359061CC6, NameHash = 0x63555D28)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 0)]
        /* 0x10 */ public TkPaletteTexture Palette;
    }
}
