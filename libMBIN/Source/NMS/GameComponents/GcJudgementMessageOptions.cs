using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEDFF4827AD935C7, NameHash = 0x8A1CA9D7910E2ABB)]
    public class GcJudgementMessageOptions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 MessageInSettlement;
        /* 0x080 */ public NMSString0x80 MessageInSettlementSystem;
        /* 0x100 */ public NMSString0x80 MessageOutOfSettlementSystem;
    }
}
