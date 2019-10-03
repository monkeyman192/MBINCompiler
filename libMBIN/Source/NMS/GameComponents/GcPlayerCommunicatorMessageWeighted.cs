using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x92CA66BB08052620, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        public GcPlayerCommunicatorMessage Message;
        public int Weighted;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
