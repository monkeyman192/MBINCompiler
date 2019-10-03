using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x60, Alignment = 0x10, GUID = 0x8B752B493C2190FA, NameHash = 0x4BFAC826445A23F2)]
    public class TkProceduralTextureChosenOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Layer;
        [NMS(Size = 0x10)]
        public string Group;
        public TkPaletteTexture Palette;
        public bool OverrideColour;
        public Colour Colour;
        [NMS(Size = 0x20)]
        public string OptionName;
    }
}
