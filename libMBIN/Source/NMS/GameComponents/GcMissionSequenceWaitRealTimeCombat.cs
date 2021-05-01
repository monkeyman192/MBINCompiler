using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1A8, GUID = 0x9B7529D18442E956, NameHash = 0xB497A82E7D25F7C4)]
    public class GcMissionSequenceWaitRealTimeCombat : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MessageCombat;
        /* 0x100 */ public ulong Time;
        /* 0x108 */ public float Randomness;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10C */ public byte[] Padding10C;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string DisplayStat;
        /* 0x120 */ public bool StatFromNow;
        [NMS(Size = 0x80)]
        /* 0x121 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1A1 */ public byte[] EndPadding;
    }
}
