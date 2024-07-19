namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAA7CA2B2FC7A8D9, NameHash = 0xCD8CC86D)]
    public class GcMissionSequenceBounty : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 Bounty;
        [NMS(Index = 4)]
        /* 0x10 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x20 */ public VariableSizeString MessageDestroy;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString MessageEngage;
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString MessageGetToSpace;
    }
}
