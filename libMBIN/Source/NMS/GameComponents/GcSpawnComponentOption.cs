using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2C8, GUID = 0xEF6C780BE2FE91C4, NameHash = 0xA7EE5AECC28F3591)]
    public class GcSpawnComponentOption : NMSTemplate
    {
        public NMSString0x10 Name;
        public GcSeed Seed;
        public GcResourceElement SpecificModel;
    }
}
