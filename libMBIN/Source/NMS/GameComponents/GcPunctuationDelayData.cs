using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xCA4A2E012A4EF721, NameHash = 0x550D77569C679867)]
    public class GcPunctuationDelayData : NMSTemplate
    {
        public List<GcPunctuationDelay> PunctuationList;
        public float DefaultDelay;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
