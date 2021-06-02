using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8D0, GUID = 0xE5B766DFB523477A, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x450 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x828 */ public GcBiomeList PerBiomeDropWeights;
        /* 0x8A8 */ public NMSString0x20 DeployableProductID;
        /* 0x8C8 */ public bool RecordsStat;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x8C9 */ public byte[] EndPadding;
    }
}
