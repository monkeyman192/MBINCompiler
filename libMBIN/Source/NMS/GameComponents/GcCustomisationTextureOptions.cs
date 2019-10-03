using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x36E3CF6D7FBAA203, NameHash = 0x6464F543A870D3F3)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        public List<GcCustomisationTextureOption> TextureOptions;
    }
}
