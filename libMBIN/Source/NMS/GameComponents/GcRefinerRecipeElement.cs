using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x79E540957090F638, NameHash = 0xE6D47DFF06BD69E5)]
    public class GcRefinerRecipeElement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcInventoryType Type;
        /* 0x14 */ public int Amount;
    }
}
