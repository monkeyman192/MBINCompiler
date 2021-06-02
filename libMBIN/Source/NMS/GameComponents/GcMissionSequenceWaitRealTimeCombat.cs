using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1A8, GUID = 0x9B7529D18442E956, NameHash = 0xB497A82E7D25F7C4)]
    public class GcMissionSequenceWaitRealTimeCombat : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageCombat;
        /* 0x100 */ public ulong Time;
        /* 0x108 */ public float Randomness;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10C */ public byte[] Padding10C;
        /* 0x110 */ public NMSString0x10 DisplayStat;
        /* 0x120 */ public bool StatFromnow;
        /* 0x121 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1A1 */ public byte[] EndPadding;
    }
}
