using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x840, GUID = 0x979E4D023E9A5424, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcNameGeneratorWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3)]
        /* 0x430 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x808 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x83C */ public byte[] EndPadding;
    }
}
