using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD8, GUID = 0xAB8AE788F4CBAFF9, NameHash = 0xF37F133693523902)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string ParentGroup;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string Name;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public int DefaultColourIdx;
        [NMS(Size = 0x10)]
        /* 0xC8 */ public string DefaultItem;
    }
}
