namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF677C1767AD4C6C, NameHash = 0xF3FD4BE5)]
    public class GcStoryEntryBranch : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Entry;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 RequiresMission;
        [NMS(Index = 2)]
        /* 0x30 */ public bool ConditionMissionComplete;
    }
}
