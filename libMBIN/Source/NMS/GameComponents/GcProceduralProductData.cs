using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66F45FF706744E95, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcProductData Product;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x410 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x7E8 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x810 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x820 */ public GcBiomeList PerBiomeDropWeights;
        /* 0x8A0 */ public int NameGeneratorLegacyRolls;
        /* 0x8A4 */ public NMSString0x20 DeployableProductID;
        /* 0x8C4 */ public bool RecordsStat;
    }
}
