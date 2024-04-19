using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AAE6DFC32B86B13, NameHash = 0x6310315CF52D5A45)]
    public class GcTriggerFeedbackState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkTriggerFeedbackData Data;
        /* 0x20 */ public GcInputActions Action;
    }
}
