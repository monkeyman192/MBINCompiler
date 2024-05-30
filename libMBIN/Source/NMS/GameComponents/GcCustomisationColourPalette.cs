using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x456D2EC9540A620, NameHash = 0x514B6B4610D263B1)]
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
