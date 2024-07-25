using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x461482BB36B61C76, NameHash = 0xCE50C939)]
    public class GcCustomisationColourGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Title;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 GroupID;
        [NMS(Index = 3)]
        /* 0x30 */ public TkPaletteTexture Palette;
        [NMS(Index = 2)]
        /* 0x38 */ public bool HiddenForFirstOption;
    }
}
