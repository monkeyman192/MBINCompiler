using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x579D64C93CF3F6D1, NameHash = 0xDB3D22C1C68F20C3)]
    public class GcTechnologyRarity : NMSTemplate
    {

		public enum TechnologyRarityEnum { Normal, VeryCommon, Common, Rare, VeryRare, Impossible, Always }
		public TechnologyRarityEnum TechnologyRarity;
    }
}