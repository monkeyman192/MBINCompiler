using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTradeData : NMSTemplate
    {
        public List<NMSString0x10> AlwaysPresentProducts;
        public List<NMSString0x10> AlwaysPresentSubstances;

        public int MinItemsForSale;
        public int MaxItemsForSale;
        public float PercentageOfItemsAreProducts;
        public int MinAmountOfProductAvailable;
        public int MaxAmountOfProductAvailable;
        public int MinAmountOfSubstanceAvailable;
        public int MaxAmountOfSubstanceAvailable;
        public bool HasStarItems;
        public int MinNumberOfStarItems;
        public int MaxNumberOfStarItems;
        public float StarItemMarkUp;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4C;
    }
}
