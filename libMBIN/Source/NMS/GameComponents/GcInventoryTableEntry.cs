using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6BC5FBD403817F20, NameHash = 0xBA68F4D576FCF49E)]
    public class GcInventoryTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcInventoryLayoutSizeType LayoutSizeType;
        /* 0x14 */ public int MaxSize;
        /* 0x18 */ public int MinSize;
    }
}
