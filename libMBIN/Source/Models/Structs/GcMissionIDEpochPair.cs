namespace libMBIN.Models.Structs
{
    public class GcMissionIDEpochPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MissionID;
        public ulong RecurrenceDeadline;
    }
}
