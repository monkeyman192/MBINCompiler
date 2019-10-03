using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xF6AEDCB258E2CFC1, NameHash = 0xB015A154CC664705)]
    public class TkResourceFilterData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string FilterName;
        public List<NMSString0x20> FilteredResources;

    }
}
