namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEE1E91CA9DFF2FD, NameHash = 0x53063C88)]
    public class GcMissionConditionWaitForTime : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong WaitTimeInSeconds;
        [NMS(Index = 1)]
        /* 0x8 */ public bool ThisConditionWillSetMissionUserDataIsThatOk;
    }
}
