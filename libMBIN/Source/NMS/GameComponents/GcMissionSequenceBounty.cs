using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0xADB211D726F9E715, NameHash = 0xB91599B59D30BF64)]
    public class GcMissionSequenceBounty : NMSTemplate      // size: 0x210
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MessageEngage;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string MessageDestroy;
        [NMS(Size = 0x10)]
        /* 0x180 */ public string Bounty;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
