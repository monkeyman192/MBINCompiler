namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E8DC0BB665ADEF9, NameHash = 0xCD771E985A27F526)]
    public class GcMissionSequenceWaitForStatMilestone : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x10 Stat;
        // size: 0x3
        public enum MilestoneEnum : uint {
            Bronze,
            Silver,
            Gold,
        }
        [NMS(Index = 2)]
        /* 0x010 */ public MilestoneEnum Milestone;
        [NMS(Index = 4)]
        /* 0x014 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x094 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x114 */ public bool EveryMilestone;
    }
}
