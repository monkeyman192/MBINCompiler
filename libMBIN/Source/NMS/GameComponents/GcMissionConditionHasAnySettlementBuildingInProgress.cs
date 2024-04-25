namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x581BD1663F042826, NameHash = 0xFBAEC9AC6033BD5A)]
    public class GcMissionConditionHasAnySettlementBuildingInProgress : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool IgnoreIfTimerActive;
    }
}
