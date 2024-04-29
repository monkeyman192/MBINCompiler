using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957E27918DADB9D0, NameHash = 0x6B3A62EF81161171)]
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
