using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, GUID = 0xF6AEDCB258E2CFC1, NameHash = 0xB015A154CC664705)]
    public class TkResourceFilterData : NMSTemplate
    {
        public NMSString0x10 FilterName;
        public List<NMSString0x20A> FilteredResources;

    }
}