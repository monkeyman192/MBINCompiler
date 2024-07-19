using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA445A2F899F574A9, NameHash = 0x66C4F827)]
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
