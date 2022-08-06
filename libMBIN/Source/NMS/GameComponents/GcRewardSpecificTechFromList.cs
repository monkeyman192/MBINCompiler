using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7C282CE33A844ED7, NameHash = 0xF33640B1865E5E4B)]
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        public List<NMSString0x10> TechList;

        public bool FailIfAllKnown;

		public enum TechListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public TechListRewardOrderEnum TechListRewardOrder;
    }
}
