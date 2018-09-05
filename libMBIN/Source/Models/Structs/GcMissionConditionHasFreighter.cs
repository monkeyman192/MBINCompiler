namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4)]
    public class GcMissionConditionHasFreighter : NMSTemplate
    {
        public int FreighterInCurrentSystem;
        public string[] FreighterInCurrentSystemValues()
        {
            return new[] { "DontCare", "Yes", "No"};
        }
    }
}
