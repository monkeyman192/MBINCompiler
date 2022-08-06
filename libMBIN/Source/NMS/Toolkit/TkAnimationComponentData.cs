using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9B91CA8A24A906BE, NameHash = 0x379CFCF1CE84CBAA)]
    public class TkAnimationComponentData : NMSTemplate
    {
        /* 0x000 */ public TkAnimationData Idle;
        /* 0x138 */ public List<TkAnimationData> Anims;
        /* 0x148 */ public List<TkAnimBlendTree> Trees;
        /* 0x158 */ public bool NetSyncAnimation;
        /* 0x160 */ public List<TkAnimJointLODData> JointLODOverrides;
    }
}
