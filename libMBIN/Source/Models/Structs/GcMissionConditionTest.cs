namespace libMBIN.Models.Structs
{
    public class GcMissionConditionTest : NMSTemplate
    {
		public enum ConditionTestEnum { AnyFalse, AllFalse, AnyTrue, AllTrue }
		public ConditionTestEnum ConditionTest;
    }
}
