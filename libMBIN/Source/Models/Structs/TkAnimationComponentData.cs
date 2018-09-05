using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x158)]
    public class TkAnimationComponentData : NMSTemplate
    {
        /* 0x00 */ public TkAnimationData Idle;
        /* 0x130 */ public List<TkAnimationData> Anims;
        /* 0x140 */ public List<TkAnimBlendTree> Trees;
        /* 0x150 */ public bool NetSyncAnimation;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x151 */ public byte[] EndPadding;
    }
}
