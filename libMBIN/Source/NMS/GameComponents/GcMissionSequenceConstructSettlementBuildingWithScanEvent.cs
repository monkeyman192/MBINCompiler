using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x643BAFE66BCD82D6, NameHash = 0x9DC327D85EF1681E)]
    public class GcMissionSequenceConstructSettlementBuildingWithScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageWhileBuilding;
        /* 0x100 */ public NMSString0x80 MessageWithItemsGathered;
        /* 0x180 */ public NMSString0x80 MessageWhenDistant;
        /* 0x200 */ public NMSString0x20A ScanEvent;
        /* 0x220 */ public float ForceCompleteSequenceAtStagePercentage;
        /* 0x224 */ public NMSString0x80 DebugText;
    }
}
