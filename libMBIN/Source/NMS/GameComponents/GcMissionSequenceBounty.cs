namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6010DAF1B8A8D15, NameHash = 0xB91599B59D30BF64)]
    public class GcMissionSequenceBounty : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x10 Bounty;
        [NMS(Index = 4)]
        /* 0x010 */ public NMSString0x80 DebugText;
        [NMS(Index = 2)]
        /* 0x090 */ public NMSString0x80 MessageDestroy;
        [NMS(Index = 1)]
        /* 0x110 */ public NMSString0x80 MessageEngage;
        [NMS(Index = 0)]
        /* 0x190 */ public NMSString0x80 MessageGetToSpace;
    }
}
