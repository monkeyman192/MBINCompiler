using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7C5DB65E2CF0F90, NameHash = 0x41BFFB2F8544AD51)]
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        public GcNPCHabitationType WorkerType;
		public enum WorkerInCurrentBaseEnum { DontCare, Yes, No }
		public WorkerInCurrentBaseEnum WorkerInCurrentBase;
    }
}