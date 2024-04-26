using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8B574543FC643C2, NameHash = 0xBFB26332AE955464)]
    public class GcBehaviourPlayAnimData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcBehaviourPlayAnimTrigger> Triggers;
        [NMS(Index = 1)]
        /* 0x20 */ public float BlendInTime;
        [NMS(Index = 2)]
        /* 0x24 */ public float BlendOutAt;
    }
}
