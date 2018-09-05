namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xC)]
    public class GcMissionConditionExpeditionCount : NMSTemplate
    {
        public int ExpeditionCount;
        public bool OnlyCountIfActive;
        public bool OnlyCountIfFueled;
        public bool OnlyCountAwaitingDebrief;
        public bool ActiveExpeditionsCountAsFueled;
        public TkEqualityEnum Test;
    }
}
