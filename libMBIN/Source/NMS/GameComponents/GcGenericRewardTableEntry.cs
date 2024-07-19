using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C174E3DFB340BCA, NameHash = 0x2A9E41D3)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcRewardTableItemList List;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x10 Id;
    }
}
