namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7166447ED105BA4, NameHash = 0x2B0199F3)]
    public class GcMissionSequenceWaitForSettlementActivity : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x20 */ public VariableSizeString MessageForConflict;
        [NMS(Index = 4)]
        /* 0x30 */ public VariableSizeString MessageForProposal;
        [NMS(Index = 2)]
        /* 0x40 */ public VariableSizeString MessageForVisitor;
        [NMS(Index = 1)]
        /* 0x50 */ public VariableSizeString MessageWhileBuilding;
    }
}
