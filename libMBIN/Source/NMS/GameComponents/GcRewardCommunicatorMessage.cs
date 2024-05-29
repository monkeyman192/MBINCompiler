using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93580CB8AA7A19E7, NameHash = 0x382AC51563627203)]
    public class GcRewardCommunicatorMessage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcPlayerCommunicatorMessage Comms;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x20A FailureMessageBusy;
        [NMS(Index = 1)]
        /* 0x70 */ public NMSString0x20A FailureMessageNotInShip;
    }
}
