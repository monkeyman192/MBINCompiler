using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11FAD9442CE68B69, NameHash = 0x41BFFB2F8544AD51)]
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        // size: 0x3
        public enum WorkerInCurrentBaseEnum : uint {
            DontCare,
            Yes,
            No,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public WorkerInCurrentBaseEnum WorkerInCurrentBase;
        [NMS(Index = 0)]
        /* 0x4 */ public GcNPCHabitationType WorkerType;
    }
}
