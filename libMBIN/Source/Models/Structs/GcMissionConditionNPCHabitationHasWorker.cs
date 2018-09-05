namespace libMBIN.Models.Structs
{
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        public GcNPCHabitationType WorkerType;
        public int WorkerInCurrentBase;
        public string[] WorkerInCurrentBaseValues()
        {
            return new[] { "DontCare", "Yes", "No"};
        }
    }
}
