using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66F45FF706744E95, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcProductData Product;
        [NMS(Index = 4, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x410 */ public GcProductProceduralOnlyData[] ProceduralData;
        [NMS(Index = 0)]
        /* 0x7E8 */ public GcNameGeneratorWord NameGeneratorBase;
        [NMS(Index = 1)]
        /* 0x810 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        [NMS(Index = 5)]
        /* 0x820 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Index = 2)]
        /* 0x8A0 */ public int NameGeneratorLegacyRolls;
        [NMS(Index = 6)]
        /* 0x8A4 */ public NMSString0x20 DeployableProductID;
        [NMS(Index = 7)]
        /* 0x8C4 */ public bool RecordsStat;
    }
}
