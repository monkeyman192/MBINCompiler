namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceSetGlobalMission : NMSTemplate
    {
		public enum GlobalMissionEnum { Atlas, BlackHole, Anomaly, Explore }
		public GlobalMissionEnum GlobalMission;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
