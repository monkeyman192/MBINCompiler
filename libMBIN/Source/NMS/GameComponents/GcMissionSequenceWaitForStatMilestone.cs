namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F3BD2EC3DE3BEF, NameHash = 0x9A99FBF9)]
    public class GcMissionSequenceWaitForStatMilestone : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Stat;
        // size: 0x3
        public enum MilestoneEnum : uint {
            Bronze,
            Silver,
            Gold,
        }
        [NMS(Index = 2)]
        /* 0x30 */ public MilestoneEnum Milestone;
        [NMS(Index = 3)]
        /* 0x34 */ public bool EveryMilestone;
    }
}
