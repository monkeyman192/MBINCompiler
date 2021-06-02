using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x60, Alignment = 0x10, GUID = 0xEFA68130B1B05C91, NameHash = 0x4BFAC826445A23F2)]
    public class TkProceduralTextureChosenOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Layer;
        /* 0x10 */ public NMSString0x10 Group;
        /* 0x20 */ public TkPaletteTexture Palette;
        /* 0x28 */ public bool OverrideColour;
        /* 0x30 */ public Colour Colour;
        /* 0x40 */ public NMSString0x20 OptionName;
    }
}
