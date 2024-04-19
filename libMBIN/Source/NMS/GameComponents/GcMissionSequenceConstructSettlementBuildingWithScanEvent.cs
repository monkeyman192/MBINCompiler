namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x994472AEF21AC74F, NameHash = 0x9DC327D85EF1681E)]
    public class GcMissionSequenceConstructSettlementBuildingWithScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ScanEvent;
        /* 0x020 */ public float ForceCompleteSequenceAtStagePercentage;
        /* 0x024 */ public NMSString0x80 DebugText;
        /* 0x0A4 */ public NMSString0x80 Message;
        /* 0x124 */ public NMSString0x80 MessageWhenDistant;
        /* 0x1A4 */ public NMSString0x80 MessageWhileBuilding;
        /* 0x224 */ public NMSString0x80 MessageWithItemsGathered;
    }
}
