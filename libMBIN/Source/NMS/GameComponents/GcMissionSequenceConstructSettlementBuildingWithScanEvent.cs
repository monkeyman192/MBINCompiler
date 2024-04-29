namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4EBE50FF7B252D3, NameHash = 0x9DC327D85EF1681E)]
    public class GcMissionSequenceConstructSettlementBuildingWithScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A ScanEvent;
        [NMS(Index = 5)]
        /* 0x020 */ public float ForceCompleteSequenceAtStagePercentage;
        [NMS(Index = 6)]
        /* 0x024 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A4 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x124 */ public NMSString0x80 MessageWhenDistant;
        [NMS(Index = 1)]
        /* 0x1A4 */ public NMSString0x80 MessageWhileBuilding;
        [NMS(Index = 2)]
        /* 0x224 */ public NMSString0x80 MessageWithItemsGathered;
    }
}
