namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0D46638AF53103D, NameHash = 0xCD771E985A27F526)]
    public class GcMissionSequenceWaitForStatMilestone : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Stat;
        // size: 0x3
        public enum MilestoneEnum : uint {
            Bronze,
            Silver,
            Gold,
        }
        /* 0x010 */ public MilestoneEnum Milestone;
        /* 0x014 */ public NMSString0x80 DebugText;
        /* 0x094 */ public NMSString0x80 Message;
        /* 0x114 */ public bool EveryMilestone;
    }
}
