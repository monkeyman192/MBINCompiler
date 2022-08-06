using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA8E9E19BEA438001, NameHash = 0x5DE2B54C774CA122)]
    public class TkTriggerFeedbackData : NMSTemplate
    {
        public enum FeedbackTypeEnum { None, Feedback, Weapon, Vibration }
        /* 0x0 */ public FeedbackTypeEnum FeedbackType;
        /* 0x4 */ public float Strength;
        /* 0x8 */ public float Position;
        /* 0xC */ public float Frequency;
    }
}
