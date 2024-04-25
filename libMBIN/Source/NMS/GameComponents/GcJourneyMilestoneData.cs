namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8BF2A6A86ADC900, NameHash = 0xC35BDABF76750407)]
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
