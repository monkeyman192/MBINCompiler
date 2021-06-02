using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x4929F19D9BBB8313, NameHash = 0xEBD25F53C92AC4C7)]
    public class GcTelemetryStat : NMSTemplate
    {
        public NMSString0x10 Id;
        public NMSString0x10 Type;
        public int Value;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
