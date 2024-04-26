using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AAE6DFC32B86B13, NameHash = 0x6310315CF52D5A45)]
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
