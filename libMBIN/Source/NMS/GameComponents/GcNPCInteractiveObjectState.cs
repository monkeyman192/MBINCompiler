using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D654525CA8E7368, NameHash = 0x8D18F9F6D2A592B3)]
    public class GcNPCInteractiveObjectState : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x00 */ public List<GcNPCProbabilityAnimationData> Animations;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
        [NMS(Index = 20)]
        /* 0x20 */ public List<GcNPCInteractiveObjectStateTransition> Transitions;
        [NMS(Index = 12)]
        /* 0x30 */ public float BlendTime;
        [NMS(Index = 13)]
        /* 0x34 */ public float EarlyOutTime;
        [NMS(Index = 17)]
        /* 0x38 */ public int MaxAnims;
        [NMS(Index = 19)]
        /* 0x3C */ public float MaxTime;
        [NMS(Index = 16)]
        /* 0x40 */ public int MinAnims;
        [NMS(Index = 18)]
        /* 0x44 */ public float MinTime;
        [NMS(Index = 10)]
        /* 0x48 */ public GcNPCPropType Prop;
        [NMS(Index = 11)]
        /* 0x4C */ public GcNPCSeatedPosture SeatedPosture;
        [NMS(Index = 15)]
        /* 0x50 */ public float SpineAdjustAmount;
        [NMS(Index = 5)]
        /* 0x54 */ public NMSString0x40 LookAtNode;
        [NMS(Index = 9)]
        /* 0x94 */ public bool CanConverse;
        [NMS(Index = 3)]
        /* 0x95 */ public bool FaceInvNodeDir;
        [NMS(Index = 6)]
        /* 0x96 */ public bool FaceLookAt;
        [NMS(Index = 2)]
        /* 0x97 */ public bool FaceNodeDir;
        [NMS(Index = 1)]
        /* 0x98 */ public bool FaceSpawnDir;
        [NMS(Index = 4)]
        /* 0x99 */ public bool LookAtModel;
        [NMS(Index = 7)]
        /* 0x9A */ public bool MaintainLookAt;
        [NMS(Index = 8)]
        /* 0x9B */ public bool PlayIdles;
    }
}
