using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82DD1A0F7255A793, NameHash = 0x6B3A62EF81161171)]
    public class GcUnlockableItemTree : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcUnlockableItemTreeNode Root;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 CostTypeID;
    }
}
