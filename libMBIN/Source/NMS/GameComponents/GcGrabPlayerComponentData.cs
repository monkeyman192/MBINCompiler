using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AB0F9298534BA99, NameHash = 0xDE6FCE33E294F619)]
    public class GcGrabPlayerComponentData : NMSTemplate
    {
        /* 0x000 */ public Vector3f GrabOffset;
        /* 0x010 */ public NMSString0x10 DamageType;
        /* 0x020 */ public NMSString0x10 DefendAnim;
        /* 0x030 */ public NMSString0x10 GrabAnim;
        /* 0x040 */ public NMSString0x10 HitReactAnim;
        /* 0x050 */ public NMSString0x10 HoldAnim;
        /* 0x060 */ public NMSString0x10 IdleAnim;
        /* 0x070 */ public NMSString0x10 PlayerGrabbedAnim;
        /* 0x080 */ public Vector2f HitReactAngles;
        /* 0x088 */ public Vector2f LookAroundAngles;
        /* 0x090 */ public Vector2f LookAroundAnglesFine;
        /* 0x098 */ public Vector2f LookAroundTime;
        /* 0x0A0 */ public Vector2f LookAroundTrackTime;
        /* 0x0A8 */ public Vector2f LookAtPlayerTime;
        /* 0x0B0 */ public Vector2f SleepTime;
        /* 0x0B8 */ public float ActivateRange;
        /* 0x0BC */ public float BodgeInputAngle;
        /* 0x0C0 */ public float BodgeOutputAngle;
        /* 0x0C4 */ public float CooldownTime;
        /* 0x0C8 */ public float DamageTime;
        /* 0x0CC */ public float EjectImpulse;
        /* 0x0D0 */ public float FocusRange;
        /* 0x0D4 */ public float GrabAttachStrength;
        /* 0x0D8 */ public GcAudioWwiseEvents GrabBeginAudioEvent;
        /* 0x0DC */ public float GrabBlendTime;
        /* 0x0E0 */ public GcAudioWwiseEvents GrabEndAudioEvent;
        /* 0x0E4 */ public float GrabRadius;
        /* 0x0E8 */ public float HitReactAnimChance;
        /* 0x0EC */ public float HoldTime;
        /* 0x0F0 */ public float LookAroundFineModifier;
        /* 0x0F4 */ public float LookAtPlayerChance;
        /* 0x0F8 */ public float LungeRadius;
        /* 0x0FC */ public float MaxLookAngle;
        /* 0x100 */ public float RestTime;
        /* 0x104 */ public float SleepChance;
        /* 0x108 */ public float TrackTime;
        /* 0x10C */ public float TriggerRange;
        /* 0x110 */ public NMSString0x100 GrabJoint;
        /* 0x210 */ public NMSString0x100 LookJoint;
    }
}
