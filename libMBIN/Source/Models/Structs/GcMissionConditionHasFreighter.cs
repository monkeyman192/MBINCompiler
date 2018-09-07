namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4)]
    public class GcMissionConditionHasFreighter : NMSTemplate
    {
		public enum FreighterInCurrentSystemEnum { DontCare, Yes, No }
		public FreighterInCurrentSystemEnum FreighterInCurrentSystem;
    }
}
