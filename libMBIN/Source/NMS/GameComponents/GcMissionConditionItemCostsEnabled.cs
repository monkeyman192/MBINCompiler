using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96B2EE4D791B4C07, NameHash = 0xF7D2DC59)]
    public class GcMissionConditionItemCostsEnabled : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 1)]
        /* 0x4 */ public bool Enabled;
    }
}
