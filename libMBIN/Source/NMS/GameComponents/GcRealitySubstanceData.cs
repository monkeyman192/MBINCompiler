using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRealitySubstanceData : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x20 NameLower;
        public NMSString0x10 ID;
        public NMSString0x20 Symbol;
        public TkTextureResource Icon;
        public TkModelResource DebrisFile;
        public VariableSizeString Subtitle;
        public VariableSizeString Description;
        public Colour Colour;
        public Colour WorldColour;
        public int BaseValue;
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public GcLegality Legality;
        public int ChargeValue;
        public GcItemPriceModifiers Cost;
        public float NormalisedValueOnWorld;
        public float NormalisedValueOffWorld;
    }
}
