using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x66F519D76005DDAF, NameHash = 0x3FF01CECDEAECD1D)]
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        public List<NMSString0x10> ProductIds;
        [NMS(Size = 0x10)]
        public string DisplayProductId;
        [NMS(Size = 0x20)]
        public string SetName;
    }
}
