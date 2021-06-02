using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x1C2BCA5F2CBE864B, NameHash = 0x8FD3FE17A0260717)]
    public class GcCreatureFoodList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 FoodProduct;
        /* 0x10 */ public NMSString0x80 ResourceFile;
        /* 0x90 */ public NMSString0x10 DebrisEffect;
    }
}
