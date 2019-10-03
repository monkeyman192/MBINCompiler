using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x1D38968F5DD96A5, NameHash = 0x8D18F9F6D2A592B3)]
    public class GcNPCInteractiveObjectState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public bool FaceSpawnDir;
        /* 0x10 */ public bool FaceNodeDir;
        /* 0x11 */ public bool FaceInvNodeDir;
        /* 0x12 */ public bool LookAtModel;
        [NMS(Size = 0x40)]
        /* 0x14 */ public string LookAtNode;
        /* 0x54 */ public bool FaceLookA;
        /* 0x55 */ public bool MaintainLookAt;
        /* 0x56 */ public bool PlayIdles;
        /* 0x57 */ public bool CanConverse;
        /* 0x58 */ public GcNPCPropTypes Prop;
        /* 0x5C */ public GcNPCSeatedPosture SeatedPosture;
        /* 0x60 */ public float BlendTime;
        /* 0x64 */ public float EarlyOutTime;
        /* 0x68 */ public List<GcNPCProbabilityAnimationData> Animations;
        /* 0x78 */ public int MinAnims;
        /* 0x7C */ public int MaxAnims;
        /* 0x80 */ public float MinTime;
        /* 0x84 */ public float MaxTime;
        /* 0x88 */ public List<GcNPCInteractiveObjectStateTransition> Transitions;
    }
}
