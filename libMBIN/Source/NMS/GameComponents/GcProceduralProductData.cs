using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x870, GUID = 0xD6FD959ED50CD875, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3)]
        /* 0x440 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x818 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x20)]
        /* 0x84C */ public string DeployableProductID;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x86C */ public byte[] EndPadding;
    }
}
