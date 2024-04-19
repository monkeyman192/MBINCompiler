using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF1A3E1FDE495DE0, NameHash = 0x8D18F9F6D2A592B3)]
    public class GcNPCInteractiveObjectState : NMSTemplate
    {
        /* 0x00 */ public List<GcNPCProbabilityAnimationData> Animations;
        /* 0x10 */ public NMSString0x10 Name;
        /* 0x20 */ public List<GcNPCInteractiveObjectStateTransition> Transitions;
        /* 0x30 */ public float BlendTime;
        /* 0x34 */ public float EarlyOutTime;
        /* 0x38 */ public int MaxAnims;
        /* 0x3C */ public float MaxTime;
        /* 0x40 */ public int MinAnims;
        /* 0x44 */ public float MinTime;
        /* 0x48 */ public GcNPCPropType Prop;
        /* 0x4C */ public GcNPCSeatedPosture SeatedPosture;
        /* 0x50 */ public float SpineAdjustAmount;
        /* 0x54 */ public NMSString0x40 LookAtNode;
        /* 0x94 */ public bool CanConverse;
        /* 0x95 */ public bool FaceInvNodeDir;
        /* 0x96 */ public bool FaceLookAt;
        /* 0x97 */ public bool FaceNodeDir;
        /* 0x98 */ public bool FaceSpawnDir;
        /* 0x99 */ public bool LookAtModel;
        /* 0x9A */ public bool MaintainLookAt;
        /* 0x9B */ public bool PlayIdles;
    }
}
