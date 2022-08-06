using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB53BA0DB9BED6F2B, NameHash = 0x814E1DAF35C8BB77)]
    public class GcNameGeneratorWord : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Word;
        /* 0x20 */ public int NumOptions;
    }
}
