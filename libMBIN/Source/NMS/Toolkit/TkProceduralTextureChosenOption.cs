using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD319115F51379D0, NameHash = 0x4BFAC826445A23F2)]
    public class TkProceduralTextureChosenOption : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 5)]
        /* 0x10 */ public NMSString0x20A OptionName;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 Group;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Layer;
        [NMS(Index = 2)]
        /* 0x50 */ public TkPaletteTexture Palette;
        [NMS(Index = 3)]
        /* 0x58 */ public bool OverrideColour;
    }
}
