using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x1F78F7E6ABC7B3B2, NameHash = 0xDB9BCAEA43E96FA6)]
    public class GcStatGroupData : NMSTemplate
    {
        public NMSString0x10 GroupName;
        public List<NMSString0x10> TrackedStats;
    }
}