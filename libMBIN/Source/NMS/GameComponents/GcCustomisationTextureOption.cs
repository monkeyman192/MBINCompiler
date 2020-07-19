using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xE49536D3319A2AE4, NameHash = 0xCDB7AC6D11C9DF03)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string TextureOptionsID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Layer;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string Group;
        /* 0x30 */ public TkPaletteTexture Palette;
        /* 0x38 */ public List<NMSString0x20> Options;
        /* 0x48 */ public List<NMSString0x20> Tips;
    }
}
