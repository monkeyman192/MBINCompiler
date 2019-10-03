using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0xCC29C53D1D9BEED, NameHash = 0xFE5851C36CE8242F)]
    public class GcRewardTeachWord : NMSTemplate
    {
        public GcAlienRace Race;
        public bool UseCategory;
        public GcWordCategoryTableEnum Category;
        public int AmountMin;
        public int AmountMax;
    }
}
