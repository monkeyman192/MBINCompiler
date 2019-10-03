using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x254FD01AB6B98C6A, NameHash = 0x85BD8B90D73C1D42)]
    public class GcRarity : NMSTemplate
    {

		public enum RarityEnum { Common, Uncommon, Rare }
		public RarityEnum Rarity;
    }
}
