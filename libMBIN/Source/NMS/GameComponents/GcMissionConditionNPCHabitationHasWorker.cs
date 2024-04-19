using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B414C643A992848, NameHash = 0x41BFFB2F8544AD51)]
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        // size: 0x3
        public enum WorkerInCurrentBaseEnum : uint {
            DontCare,
            Yes,
            No,
        }
        /* 0x0 */ public WorkerInCurrentBaseEnum WorkerInCurrentBase;
        /* 0x4 */ public GcNPCHabitationType WorkerType;
    }
}
