using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFBC9C6E19BD69FB6, NameHash = 0xEDB11DA4)]
    public class GcInventoryTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public GcInventoryLayoutSizeType LayoutSizeType;
        [NMS(Index = 2)]
        /* 0x14 */ public int MaxSize;
        [NMS(Index = 1)]
        /* 0x18 */ public int MinSize;
    }
}
