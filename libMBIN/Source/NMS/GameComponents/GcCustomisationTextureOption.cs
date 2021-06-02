using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xE49536D3319A2AE4, NameHash = 0xCDB7AC6D11C9DF03)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TextureOptionsID;
        /* 0x10 */ public NMSString0x10 Layer;
        /* 0x20 */ public NMSString0x10 Group;
        /* 0x30 */ public TkPaletteTexture Palette;
        /* 0x38 */ public List<NMSString0x20A> Options;
        /* 0x48 */ public List<NMSString0x20A> Tips;
    }
}
