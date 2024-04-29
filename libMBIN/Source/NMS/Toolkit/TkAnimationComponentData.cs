using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4B7A38E2033CBD90, NameHash = 0x379CFCF1CE84CBAA)]
    public class TkAnimationComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public TkAnimationData Idle;
        [NMS(Index = 1)]
        /* 0x130 */ public List<TkAnimationData> Anims;
        [NMS(Index = 4)]
        /* 0x140 */ public List<TkAnimJointLODData> JointLODOverrides;
        [NMS(Index = 2)]
        /* 0x150 */ public List<TkAnimBlendTree> Trees;
        [NMS(Index = 3)]
        /* 0x160 */ public bool NetSyncAnimations;
    }
}
