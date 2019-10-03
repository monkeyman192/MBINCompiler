using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xF38F4876AD3B119F, NameHash = 0x6DFF01CC3FB67220)]
    public class TkButtonImageLookup : NMSTemplate
    {
        public List<TkButtonPathMapping> Lookup;
    }
}
