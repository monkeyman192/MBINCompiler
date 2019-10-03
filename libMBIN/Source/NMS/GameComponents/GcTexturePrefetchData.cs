using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x43D35B6DB970549F, NameHash = 0xE2910F7CA28A0271)]
    public class GcTexturePrefetchData : NMSTemplate
    {
        public List<NMSString0x80> Textures;
    }
}
