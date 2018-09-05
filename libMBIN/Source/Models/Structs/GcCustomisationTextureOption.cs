using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x48)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TextureOptionsID;
        [NMS(Size = 0x10)]
        public string Layer;
        [NMS(Size = 0x10)]
        public string Group;
        public TkPaletteTexture Palette;
        public List<NMSString0x20> Options;
    }
}
