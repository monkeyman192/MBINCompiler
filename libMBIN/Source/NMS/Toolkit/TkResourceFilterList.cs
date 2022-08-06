using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xD292EC640A03C7BF, NameHash = 0x84DCB310035A7429)]
    public class TkResourceFilterList : NMSTemplate
    {
        public List<TkResourceFilterData> Filters;

    }
}