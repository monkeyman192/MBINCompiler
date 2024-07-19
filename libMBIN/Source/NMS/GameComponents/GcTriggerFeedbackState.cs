using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x939D86615FB5C76B, NameHash = 0xAFACAFA7)]
    public class GcTriggerFeedbackState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public TkTriggerFeedbackData Data;
        [NMS(Index = 1)]
        /* 0x20 */ public GcInputActions Action;
    }
}
