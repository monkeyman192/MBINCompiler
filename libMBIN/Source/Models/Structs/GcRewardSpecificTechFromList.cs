using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        public List<NMSString0x10> TechList;

		public enum TechListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public TechListRewardOrderEnum TechListRewardOrder;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
