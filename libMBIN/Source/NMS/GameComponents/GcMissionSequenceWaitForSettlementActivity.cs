namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEF5E7B3F37D402E, NameHash = 0x13DC6DC343F05)]
    public class GcMissionSequenceWaitForSettlementActivity : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x100 */ public NMSString0x80 MessageForConflict;
        [NMS(Index = 4)]
        /* 0x180 */ public NMSString0x80 MessageForProposal;
        [NMS(Index = 2)]
        /* 0x200 */ public NMSString0x80 MessageForVisitor;
        [NMS(Index = 1)]
        /* 0x280 */ public NMSString0x80 MessageWhileBuilding;
    }
}
