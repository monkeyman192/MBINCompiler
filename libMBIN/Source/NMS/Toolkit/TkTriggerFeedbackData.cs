namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5D8E386894CA5E6B, NameHash = 0x5DE2B54C774CA122)]
    public class TkTriggerFeedbackData : NMSTemplate
    {
        // size: 0x4
        public enum FeedbackTypeEnum : uint {
            None,
            Feedback,
            Weapon,
            Vibration,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FeedbackTypeEnum FeedbackType;
        [NMS(Index = 3)]
        /* 0x4 */ public float Frequency;
        [NMS(Index = 2)]
        /* 0x8 */ public float Position;
        [NMS(Index = 1)]
        /* 0xC */ public float Strength;
    }
}
