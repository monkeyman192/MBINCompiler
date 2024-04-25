namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CE170CA39CB196F, NameHash = 0x337390D414A23798)]
    public class GcMissionConditionIsAbandFreighterDoorOpen : NMSTemplate
    {
        // size: 0x4
        public enum AbandonedFreighterDoorStatusEnum : uint {
            DungeonNotReady,
            Locked,
            Opening,
            Open,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AbandonedFreighterDoorStatusEnum AbandonedFreighterDoorStatus;
    }
}
