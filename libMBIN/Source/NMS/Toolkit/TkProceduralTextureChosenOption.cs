using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF1E8C6954632A95E, NameHash = 0x4BFAC826445A23F2)]
    public class TkProceduralTextureChosenOption : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public NMSString0x20A OptionName;
        /* 0x30 */ public NMSString0x10 Group;
        /* 0x40 */ public NMSString0x10 Layer;
        /* 0x50 */ public TkPaletteTexture Palette;
        /* 0x58 */ public bool OverrideColour;
    }
}
