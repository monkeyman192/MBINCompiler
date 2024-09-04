using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9261EC5C5ACF97E7, NameHash = 0x5F8D3016)]
    public class GcGrabPlayerComponentData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public Vector3f GrabOffset;
        [NMS(Index = 8)]
        /* 0x010 */ public NMSString0x10 DamageType;
        [NMS(Index = 2)]
        /* 0x020 */ public NMSString0x10 DefendAnim;
        [NMS(Index = 4)]
        /* 0x030 */ public NMSString0x10 GrabAnim;
        [NMS(Index = 6)]
        /* 0x040 */ public NMSString0x10 HitReactAnim;
        [NMS(Index = 5)]
        /* 0x050 */ public NMSString0x10 HoldAnim;
        [NMS(Index = 3)]
        /* 0x060 */ public NMSString0x10 IdleAnim;
        [NMS(Index = 7)]
        /* 0x070 */ public NMSString0x10 PlayerGrabbedAnim;
        [NMS(Index = 26)]
        /* 0x080 */ public Vector2f HitReactAngles;
        [NMS(Index = 35)]
        /* 0x088 */ public Vector2f LookAroundAngles;
        [NMS(Index = 36)]
        /* 0x090 */ public Vector2f LookAroundAnglesFine;
        [NMS(Index = 34)]
        /* 0x098 */ public Vector2f LookAroundTime;
        [NMS(Index = 30)]
        /* 0x0A0 */ public Vector2f LookAroundTrackTime;
        [NMS(Index = 32)]
        /* 0x0A8 */ public Vector2f LookAtPlayerTime;
        [NMS(Index = 38)]
        /* 0x0B0 */ public Vector2f SleepTime;
        [NMS(Index = 27)]
        /* 0x0B8 */ public float ActivateRange;
        [NMS(Index = 23)]
        /* 0x0BC */ public float BodgeInputAngle;
        [NMS(Index = 24)]
        /* 0x0C0 */ public float BodgeOutputAngle;
        [NMS(Index = 20)]
        /* 0x0C4 */ public float CooldownTime;
        [NMS(Index = 9)]
        /* 0x0C8 */ public float DamageTime;
        [NMS(Index = 17)]
        /* 0x0CC */ public float EjectImpulse;
        [NMS(Index = 28)]
        /* 0x0D0 */ public float FocusRange;
        [NMS(Index = 15)]
        /* 0x0D4 */ public float GrabAttachStrength;
        [NMS(Index = 11)]
        /* 0x0D8 */ public GcAudioWwiseEvents GrabBeginAudioEvent;
        [NMS(Index = 16)]
        /* 0x0DC */ public float GrabBlendTime;
        [NMS(Index = 12)]
        /* 0x0E0 */ public GcAudioWwiseEvents GrabEndAudioEvent;
        [NMS(Index = 14)]
        /* 0x0E4 */ public float GrabRadius;
        [NMS(Index = 25)]
        /* 0x0E8 */ public float HitReactAnimChance;
        [NMS(Index = 19)]
        /* 0x0EC */ public float HoldTime;
        [NMS(Index = 31)]
        /* 0x0F0 */ public float LookAroundFineModifier;
        [NMS(Index = 33)]
        /* 0x0F4 */ public float LookAtPlayerChance;
        [NMS(Index = 13)]
        /* 0x0F8 */ public float LungeRadius;
        [NMS(Index = 22)]
        /* 0x0FC */ public float MaxLookAngle;
        [NMS(Index = 21)]
        /* 0x100 */ public float RestTime;
        [NMS(Index = 37)]
        /* 0x104 */ public float SleepChance;
        [NMS(Index = 29)]
        /* 0x108 */ public float TrackTime;
        [NMS(Index = 10)]
        /* 0x10C */ public float TriggerRange;
        [NMS(Index = 1)]
        /* 0x110 */ public NMSString0x100 GrabJoint;
        [NMS(Index = 0)]
        /* 0x210 */ public NMSString0x100 LookJoint;
    }
}
