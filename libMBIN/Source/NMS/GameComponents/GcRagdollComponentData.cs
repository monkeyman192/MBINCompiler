using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A1D59FA16493064, NameHash = 0xBA126FE5)]
    public class GcRagdollComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcEasyRagdollSetUpData EasySetUpData;
        [NMS(Index = 26)]
        /* 0x030 */ public List<NMSString0x40> OtherKnownAnimations;
        [NMS(Index = 4)]
        /* 0x040 */ public List<GcRagdollBone> RagdollBones;
        [NMS(Index = 19)]
        /* 0x050 */ public float AnimationSpeedOverride;
        [NMS(Index = 21)]
        /* 0x054 */ public float BlendIntoStartPoseDuration;
        [NMS(Index = 25)]
        /* 0x058 */ public float InertiaScale;
        [NMS(Index = 14)]
        /* 0x05C */ public float JointFriction;
        [NMS(Index = 16)]
        /* 0x060 */ public float KineticEnergyForRest;
        [NMS(Index = 20)]
        /* 0x064 */ public float MaxDamping;
        [NMS(Index = 17)]
        /* 0x068 */ public float MaxWaitForRest;
        [NMS(Index = 18)]
        /* 0x06C */ public float MinWaitForRest;
        [NMS(Index = 5)]
        /* 0x070 */ public float ModelScaleAtCreation;
        [NMS(Index = 15)]
        /* 0x074 */ public float OverallDurationScale;
        [NMS(Index = 23)]
        /* 0x078 */ public float PhasingOutRagdollDuration;
        [NMS(Index = 22)]
        /* 0x07C */ public float PlayAnimationDuration;
        [NMS(Index = 24)]
        /* 0x080 */ public float WholeBodyMass;
        [NMS(Index = 11)]
        /* 0x084 */ public NMSString0x40 FallAnimation_Back;
        [NMS(Index = 10)]
        /* 0x0C4 */ public NMSString0x40 FallAnimation_Front;
        [NMS(Index = 12)]
        /* 0x104 */ public NMSString0x40 FallAnimation_Left;
        [NMS(Index = 13)]
        /* 0x144 */ public NMSString0x40 FallAnimation_Right;
        [NMS(Index = 7)]
        /* 0x184 */ public NMSString0x40 GetUpAnimation_Back;
        [NMS(Index = 6)]
        /* 0x1C4 */ public NMSString0x40 GetUpAnimation_Front;
        [NMS(Index = 8)]
        /* 0x204 */ public NMSString0x40 GetUpAnimation_Left;
        [NMS(Index = 9)]
        /* 0x244 */ public NMSString0x40 GetUpAnimation_Right;
        [NMS(Index = 3)]
        /* 0x284 */ public NMSString0x40 Name;
        [NMS(Index = 1)]
        /* 0x2C4 */ public bool EasySetUp;
        [NMS(Index = 0)]
        /* 0x2C5 */ public bool Enabled;
    }
}
