using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF6CFDA7B94887F7, NameHash = 0x56711152687FE3A9)]
    public class GcMissionConditionItemCostsEnabled : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 1)]
        /* 0x4 */ public bool Enabled;
    }
}
