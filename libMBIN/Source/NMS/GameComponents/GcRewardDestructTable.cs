using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCAF4275C40A91D9C, NameHash = 0x5ED90B1D007B2123)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 9)]
        public GcRewardDestructRarities[] Categories;
    }
}
