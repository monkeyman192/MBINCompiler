using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcProductData : NMSTemplate
    {
        public NMSString0x10 Id;
        public NMSString0x80 Name;
        public NMSString0x80 NameLower;
        public VariableSizeString Subtitle;
        public VariableSizeString Description;
        public NMSString0x20 Hint;
        public TkModelResource Debis;
        public int BaseValue;
        public int Level;
        public TkTextureResource Icon;
        public Colour Colour;
        public GcRealitySubstanceCategory SubstanceCategory;
        public GcProductCategory Category;
        public GcRarity Rarity;
        public GcLegality Legality;
        public bool Consumable;
        public int ChargeValue;
        public List<GcTechnologyRequirement> Requirements;
        public GcItemPriceModifiers Cost;
        public bool SpecificChargeOnly;
        public float NormalisedValueOnWorld;
        public float NormalisedValueOffWorld;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        [NMS(Ignore = true)]
        public int EmptyNode2;
    }
}
