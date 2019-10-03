using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x1C2BCA5F2CBE864B, NameHash = 0x8FD3FE17A0260717)]
    public class GcCreatureFoodList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string FoodProduct;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string ResourceFile;
        [NMS(Size = 0x80)]
        /* 0x90 */ public string DebrisEffect;
    }
}
