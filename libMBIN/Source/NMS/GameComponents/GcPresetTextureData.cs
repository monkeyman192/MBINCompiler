using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7DFFC6F281EA6394, NameHash = 0x1B6B9D6D222BACA6)]
    public class GcPresetTextureData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x100)]
        public string Filename;
    }
}
