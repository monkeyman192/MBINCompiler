namespace libMBIN.Models.Structs
{
    public class GcMissionConditionTest : NMSTemplate
    {
        public int ConditionTest;
        public string[] ConditionTestValues()
        {
            return new[] { "AnyFalse", "AllFalse", "AnyTrue", "AllTrue"};
        }
    }
}
