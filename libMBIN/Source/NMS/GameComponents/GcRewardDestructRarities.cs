using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x76842D5545DF5D3F, NameHash = 0x72703AC399E3162F)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        public GcRewardDestructEntry[] Rarities;
    }
}
