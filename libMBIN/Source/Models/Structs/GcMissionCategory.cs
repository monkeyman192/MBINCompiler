namespace libMBIN.Models.Structs
{
    public class GcMissionCategory : NMSTemplate
    {
		public enum MissionCategoryEnum { Info, Mission, Danger, Urgent }
		public MissionCategoryEnum MissionCategory;
    }
}
