using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x15E8BBC4FDB928FE, NameHash = 0x87586DC48C5F162B)]
    public class GcSubstanceAmount : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        [NMS(Size = 0x10)]
        public string Specific;
        [NMS(Size = 0x10)]
        public string SpecificSecondary;

        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
    }
}
