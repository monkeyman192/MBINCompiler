namespace libMBIN.Models.Structs
{
    public class GcPlayerConflictData : NMSTemplate
    {
		public enum ConflictLevelEnum { Low, Default, High }
		public ConflictLevelEnum ConflictLevel;
    }
}
