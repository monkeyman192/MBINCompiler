using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSubstanceAmount : NMSTemplate // 0x20 bytes
    {
        public int AmountMin;
        public int AmountMax;
        public NMSString0x10 Specific;

        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
    }
}
