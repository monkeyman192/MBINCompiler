using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF377484A40679A6D, NameHash = 0xB457288101712FB5)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcRewardTableItemList List;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x10 Id;
    }
}
