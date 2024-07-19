using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC70C98E95435861C, NameHash = 0x2B7A2472)]
    public class GcCustomisationColourPalette : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcPaletteData PaletteData;
        [NMS(Index = 2)]
        /* 0x410 */ public GcCustomisationColourPaletteExtraData ExtraData;
        [NMS(Index = 0)]
        /* 0x430 */ public NMSString0x10 ID;
    }
}
