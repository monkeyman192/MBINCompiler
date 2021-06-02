using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x118, GUID = 0xCE724D5DF7B4C68E, NameHash = 0x1E3880E5B9724A9C)]
    public class GcPlanetResourceIconLookup : NMSTemplate
    {
        public NMSString0x10 ID;
        public TkTextureResource Icon;
        public TkTextureResource IconBinocs;
    }
}
