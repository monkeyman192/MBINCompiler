using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8133AEDBD8CAE075, NameHash = 0xE5910A2D)]
    public class GcProceduralProductData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcProductData Product;
        [NMS(Index = 4, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x300 */ public GcProductProceduralOnlyData[] ProceduralData;
        [NMS(Index = 0)]
        /* 0x450 */ public GcNameGeneratorWord NameGeneratorBase;
        [NMS(Index = 1)]
        /* 0x478 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        [NMS(Index = 5)]
        /* 0x488 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Index = 2)]
        /* 0x510 */ public int NameGeneratorLegacyRolls;
        [NMS(Index = 6)]
        /* 0x514 */ public NMSString0x20 DeployableProductID;
        [NMS(Index = 7)]
        /* 0x534 */ public bool RecordsStat;
    }
}
