namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA43BADA39803D849, NameHash = 0x8D739B46)]
    public class GcMissionSequenceConstructSettlementBuildingWithScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A ScanEvent;
        [NMS(Index = 6)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x40 */ public VariableSizeString MessageWhenDistant;
        [NMS(Index = 1)]
        /* 0x50 */ public VariableSizeString MessageWhileBuilding;
        [NMS(Index = 2)]
        /* 0x60 */ public VariableSizeString MessageWithItemsGathered;
        [NMS(Index = 5)]
        /* 0x70 */ public float ForceCompleteSequenceAtStagePercentage;
    }
}
