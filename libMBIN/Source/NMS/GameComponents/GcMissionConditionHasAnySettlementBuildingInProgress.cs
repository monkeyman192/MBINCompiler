using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7090361BF022F596, NameHash = 0xFBAEC9AC6033BD5A)]
    public class GcMissionConditionHasAnySettlementBuildingInProgress : NMSTemplate
    {
        public bool IgnoreIfTimerActive;
    }
}
