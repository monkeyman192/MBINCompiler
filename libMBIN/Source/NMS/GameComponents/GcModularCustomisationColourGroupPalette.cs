using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E9DBBF06CFC3979, NameHash = 0xE3B5F910CD79D87A)]
    public class GcModularCustomisationColourGroupPalette : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A RequiredTextureOption;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 RequiredTextureGroup;
        [NMS(Index = 2)]
        /* 0x30 */ public TkPaletteTexture Palette;
    }
}
