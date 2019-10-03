using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xDAD738A301DDD6EC, NameHash = 0x4FA3A2D9F8D4A156)]
    public class GcMiningSubstanceData : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public bool UseRarity;
        public GcRarity Rarity;
    }
}
