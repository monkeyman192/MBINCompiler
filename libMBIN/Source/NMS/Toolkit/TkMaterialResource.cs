using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x84, GUID = 0xFD4EC7E71CA16A38, NameHash = 0x75EC92F2E9E3196F)]
    public class TkMaterialResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
