using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCAF4275C40A91D9C, NameHash = 0x5ED90B1D007B2123)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 7)]     // exe says 9 but the mbin has only room for 7...
        public GcRewardDestructRarities[] Categories;
    }
}
