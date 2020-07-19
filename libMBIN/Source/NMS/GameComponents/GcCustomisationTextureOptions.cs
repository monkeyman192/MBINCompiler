using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x73F7CED90E322947, NameHash = 0x6464F543A870D3F3)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        public List<GcCustomisationTextureOption> TextureOptions;
    }
}
