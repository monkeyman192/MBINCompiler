namespace libMBIN.Models.Structs
{
    public class GcRewardInterventionResponse : NMSTemplate
    {
        public int ResponseType;
        public string[] ResponseTypeValues()
        {
            return new[] { "DontIntervene", "InterveneWithMission", "MissionSuccess", "MissionFailure" };
        }
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string MissionID;

    }
}
