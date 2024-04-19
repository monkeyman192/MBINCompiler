namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED92D28584E03751, NameHash = 0x13DC6DC343F05)]
    public class GcMissionSequenceWaitForSettlementActivity : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 DebugText;
        /* 0x080 */ public NMSString0x80 Message;
        /* 0x100 */ public NMSString0x80 MessageForConflict;
        /* 0x180 */ public NMSString0x80 MessageForProposal;
        /* 0x200 */ public NMSString0x80 MessageForVisitor;
        /* 0x280 */ public NMSString0x80 MessageWhileBuilding;
    }
}
