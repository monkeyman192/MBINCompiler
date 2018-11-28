using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x69BD8AFBEEB526B7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS( EnumType = typeof( GcRarity.RarityEnum ) )]
        public GcRewardTableCategory[] Rarities;
    }
}
