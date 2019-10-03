using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFDC76CC341CDC6F9, NameHash = 0x81E5018BD0B4C94D)]
    public class GcAtlasMessage : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        [NMS(Size = 0x80)]
        public string CustomName;
        public Vector4f Positon;
        public int ColourIndex;
    }
}
