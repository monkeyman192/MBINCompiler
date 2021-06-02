using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24, GUID = 0xBD8A11BC4589CBE8, NameHash = 0x395C0EA1CCB017E2)]
    public class GcExpeditionDebriefPunctuation : NMSTemplate
    {
        public NMSString0x20 Punctuation;
        public float Delay;
    }
}
