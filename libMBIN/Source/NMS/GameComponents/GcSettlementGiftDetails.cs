using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC52FA2B525857CB1, NameHash = 0x8D4F825AF192C1DF)]
    public class GcSettlementGiftDetails : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Reward;
        /* 0x10 */ public NMSString0x20A LocID;
    }
}
