namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcMissionConditionWaitForTime : NMSTemplate
    {
        public ulong WaitTimeInSeconds;
    }
}
