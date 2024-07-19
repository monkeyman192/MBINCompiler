namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61BC8D0EAAC4A20F, NameHash = 0xD25190F3)]
    public class GcJourneyMilestoneData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A JourneyMilestoneTitle;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A JourneyMilestoneTitleLower;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 JourneyMilestoneId;
        [NMS(Index = 1)]
        /* 0x50 */ public int PointsToUnlock;
    }
}
