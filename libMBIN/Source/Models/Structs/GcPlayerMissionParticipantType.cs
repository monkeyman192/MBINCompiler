namespace libMBIN.Models.Structs
{
    public class GcPlayerMissionParticipantType : NMSTemplate
    {
		public enum ParticipantTypeEnum { None, MissionGiver, Primary, Secondary1, Secondary2, Secondary3, Secondary4, Secondary5, Secondary6, Secondary7, Secondary8, Secondary9 }
		public ParticipantTypeEnum ParticipantType;
    }
}
