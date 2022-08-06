using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADB211D726F9E715, NameHash = 0xB91599B59D30BF64)]
    public class GcMissionSequenceBounty : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 MessageGetToSpace;
        /* 0x080 */ public NMSString0x80 MessageEngage;
        /* 0x100 */ public NMSString0x80 MessageDestroy;
        /* 0x180 */ public NMSString0x10 Bounty;
        /* 0x190 */ public NMSString0x80 DebugText;
    }
}