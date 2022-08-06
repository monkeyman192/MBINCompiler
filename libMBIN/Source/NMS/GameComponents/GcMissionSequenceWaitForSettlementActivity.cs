using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDF9A69EB7D1BC79, NameHash = 0x00013DC6DC343F05)]
    public class GcMissionSequenceWaitForSettlementActivity : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageWhileBuilding;
        /* 0x100 */ public NMSString0x80 MessageForVisitor;
        /* 0x180 */ public NMSString0x80 MessageForConflict;
        /* 0x200 */ public NMSString0x80 MessageForProposal;
        /* 0x280 */ public NMSString0x80 DebugText;
    }
}
