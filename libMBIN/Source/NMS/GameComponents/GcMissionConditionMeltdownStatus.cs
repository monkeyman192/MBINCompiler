namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCB8BB4E2BDAE21E, NameHash = 0xEE07F277)]
    public class GcMissionConditionMeltdownStatus : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float TimeRemainingLessThan;
        [NMS(Index = 0)]
        /* 0x4 */ public bool Active;
    }
}
