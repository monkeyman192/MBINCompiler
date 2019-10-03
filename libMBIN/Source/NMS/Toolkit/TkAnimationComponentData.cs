using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x170, Alignment = 0x8, GUID = 0xF25EFDCD5D6CA29C, NameHash = 0x379CFCF1CE84CBAA)]
    public class TkAnimationComponentData : NMSTemplate
    {
        /* 0x000 */ public TkAnimationData Idle;
        /* 0x138 */ public List<TkAnimationData> Anims;
        /* 0x148 */ public List<TkAnimBlendTree> Trees;
        /* 0x158 */ public bool NetSyncAnimation;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x159 */ public byte[] Padding159;
        /* 0x160 */ public List<TkAnimJointLODData> JointLODOverrides;
    }
}
