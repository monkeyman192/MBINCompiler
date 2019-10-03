using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8DD3A54F772B9C81, NameHash = 0xDBD890CF58AC39B5)]
    public class GcTileTypeOptions : NMSTemplate
    {
        public List<TkPaletteTexture> Options;
    }
}
