using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcRewardSpecificProductRecipeFromList : NMSTemplate
    {
        public List<NMSString0x10> ProductList;

		public enum ProductListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public ProductListRewardOrderEnum ProductListRewardOrder;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
