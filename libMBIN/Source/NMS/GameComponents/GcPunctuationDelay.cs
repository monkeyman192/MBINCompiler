using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24, GUID = 0x69B0DB0BE1574A11, NameHash = 0x88FA9D134F35E97B)]
    public class GcPunctuationDelay : NMSTemplate
    {
        public NMSString0x20 Punctuation;
        public float Delay;
    }
}
