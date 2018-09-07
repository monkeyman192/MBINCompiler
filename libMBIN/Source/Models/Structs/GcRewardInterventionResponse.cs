namespace libMBIN.Models.Structs
{
    public class GcRewardInterventionResponse : NMSTemplate
    {
		public enum ResponseTypeEnum { DontIntervene, InterveneWithMission, MissionSuccess, MissionFailure }
		public ResponseTypeEnum ResponseType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string MissionID;

    }
}
