using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xA0814A4C94B662F6, NameHash = 0x6F214CFBE5603A0)]
    public class GcScanEventTriggers : NMSTemplate
    {
        public float Range;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<NMSString0x10> Triggers;
        public bool AllowRetrigger;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
