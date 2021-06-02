using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x31ACFD1014283D9A, NameHash = 0x8D18F9F6D2A592B3)]
    public class GcNPCInteractiveObjectState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public bool FaceSpawnDir;
        /* 0x10 */ public bool FaceNodeDir;
        /* 0x11 */ public bool FaceInvNodeDir;
        /* 0x12 */ public bool LookAtModel;
        /* 0x14 */ public NMSString0x40 LookAtNode;
        /* 0x54 */ public bool FaceLookA;
        /* 0x55 */ public bool MaintainLookAt;
        /* 0x56 */ public bool PlayIdles;
        /* 0x57 */ public bool CanConverse;
        /* 0x58 */ public GcNPCPropTypes Prop;
        /* 0x5C */ public GcNPCSeatedPosture SeatedPosture;
        /* 0x60 */ public float BlendTime;
        /* 0x64 */ public float EarlyOutTime;
        /* 0x68 */ public List<GcNPCProbabilityAnimationData> Animations;
        /* 0x78 */ public float SpineAdjustAmount;
        /* 0x7C */ public int MinAnims;
        /* 0x80 */ public int MaxAnims;
        /* 0x84 */ public float MinTime;
        /* 0x88 */ public float MaxTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x8C */ public byte[] Padding8C;
        /* 0x90 */ public List<GcNPCInteractiveObjectStateTransition> Transitions;
    }
}
