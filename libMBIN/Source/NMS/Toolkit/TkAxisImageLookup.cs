using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA8, GUID = 0x5C795A8C72B52DD1, NameHash = 0x6A1494CD3EC019B6)]
    public class TkAxisImageLookup : NMSTemplate
    {
        public List<TkAxisPathMapping> Lookup;
    }
}
