namespace libMBIN.Models.Structs
{
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        public GcNPCHabitationType WorkerType;
		public enum WorkerInCurrentBaseEnum { DontCare, Yes, No }
		public WorkerInCurrentBaseEnum WorkerInCurrentBase;
    }
}
