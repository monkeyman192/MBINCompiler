using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x160)]
    public class TkAnimationComponentData : NMSTemplate
    {
        /* 0x000 */ public TkAnimationData Idle;
        /* 0x138 */ public List<TkAnimationData> Anims;
        /* 0x148 */ public List<TkAnimBlendTree> Trees;
        /* 0x158 */ public bool NetSyncAnimation;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x159 */ public byte[] EndPadding;
    }
}
