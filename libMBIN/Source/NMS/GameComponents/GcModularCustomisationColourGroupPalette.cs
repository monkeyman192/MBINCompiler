using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE60D5556EB762884, NameHash = 0xE3B5F910CD79D87A)]
    public class GcModularCustomisationColourGroupPalette : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A RequiredTextureOption;
        /* 0x20 */ public NMSString0x10 RequiredTextureGroup;
        /* 0x30 */ public TkPaletteTexture Palette;
    }
}
