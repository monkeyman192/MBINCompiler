using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD6887A15EB973C41, NameHash = 0x3A5D1C2419669AFF)]
    public class GcTerrainTextureSettings : NMSTemplate
    {
        public float Brightness;
        public float Contrast;
        public float Specular;
    }
}
