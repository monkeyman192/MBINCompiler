using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD8, GUID = 0xAB8AE788F4CBAFF9, NameHash = 0xF37F133693523902)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 ParentGroup;
        /* 0x20 */ public NMSString0x20 Name;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public int DefaultColourIdx;
        /* 0xC8 */ public NMSString0x10 DefaultItem;
    }
}
