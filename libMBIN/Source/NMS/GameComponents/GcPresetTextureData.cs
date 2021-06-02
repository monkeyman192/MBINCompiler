using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x180, GUID = 0x7DFFC6F281EA6394, NameHash = 0x1B6B9D6D222BACA6)]
    public class GcPresetTextureData : NMSTemplate
    {
        public NMSString0x80 Name;
        public NMSString0x100 Filename;
    }
}