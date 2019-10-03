using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0xC44DEAC47C50A412, NameHash = 0xA1666CAA6E88F270)]
    public class GcBiomeFileListOption : NMSTemplate
    {
        public GcBiomeSubType SubType;
        [NMS(Size = 0x80)]
        public string FileName;
    }
}
