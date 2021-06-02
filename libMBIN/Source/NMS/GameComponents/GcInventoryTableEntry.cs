using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x569D04D5958E8953, NameHash = 0xBA68F4D576FCF49E)]
    public class GcInventoryTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int MinSize;
        /* 0x14 */ public int MaxSize;
        /* 0x18 */ public GcInventoryLayoutSizeType LayoutSizeType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
