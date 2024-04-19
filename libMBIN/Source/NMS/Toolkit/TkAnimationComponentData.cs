using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB5263393C2F176F4, NameHash = 0x379CFCF1CE84CBAA)]
    public class TkAnimationComponentData : NMSTemplate
    {
        /* 0x000 */ public TkAnimationData Idle;
        /* 0x130 */ public List<TkAnimationData> Anims;
        /* 0x140 */ public List<TkAnimJointLODData> JointLODOverrides;
        /* 0x150 */ public List<TkAnimBlendTree> Trees;
        /* 0x160 */ public bool NetSyncAnimations;
    }
}
