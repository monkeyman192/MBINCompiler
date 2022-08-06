using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC47449F9D4476AE, NameHash = 0xDE6FCE33E294F619)]
    public class GcGrabPlayerComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 LookJoint;
        /* 0x100 */ public NMSString0x100 GrabJoint;
        /* 0x200 */ public NMSString0x10 DefendAnim;
        /* 0x210 */ public NMSString0x10 IdleAnim;
        /* 0x220 */ public NMSString0x10 GrabAnim;
        /* 0x230 */ public NMSString0x10 HoldAnim;
        /* 0x240 */ public NMSString0x10 HitReactAnim;
        /* 0x250 */ public NMSString0x10 PlayerGrabbedAnim;
        /* 0x260 */ public NMSString0x10 DamageType;
        /* 0x270 */ public float DamageTime;
        /* 0x274 */ public float TriggerRange;
        /* 0x278 */ public GcAudioWwiseEvents GrabBeginAudioEvent;
        /* 0x27C */ public GcAudioWwiseEvents GrabEndAudioEvent;
        /* 0x280 */ public float LungeRadius;
        /* 0x284 */ public float GrabRadius;
        /* 0x288 */ public float GrabAttachStrength;
        /* 0x28C */ public float GrabBlendTime;
        /* 0x290 */ public float EjectImpulse;
        /* 0x2A0 */ public Vector3f GrabOffset;
        /* 0x2B0 */ public float HoldTime;
        /* 0x2B4 */ public float CooldownTime;
        /* 0x2B8 */ public float RestTime;
        /* 0x2BC */ public float MaxLookAngle;
        /* 0x2C0 */ public float BodgeInputAngle;
        /* 0x2C4 */ public float BodgeOutputAngle;
        /* 0x2C8 */ public float HitReactAnimChance;
        /* 0x2CC */ public Vector2f HitReactAngles;
        /* 0x2D4 */ public float ActivateRange;
        /* 0x2D8 */ public float FocusRange;
        /* 0x2DC */ public float TrackTime;
        /* 0x2E0 */ public Vector2f LookAroundTrackTime;
        /* 0x2E8 */ public float LookAroundFineModifier;
        /* 0x2EC */ public Vector2f LookAtPlayerTime;
        /* 0x2F4 */ public float LookAtPlayerChance;
        /* 0x2F8 */ public Vector2f LookAroundTime;
        /* 0x300 */ public Vector2f LookAroundAngles;
        /* 0x308 */ public Vector2f LookAroundAnglesFine;
        /* 0x310 */ public float SleepChance;
        /* 0x314 */ public Vector2f SleepTime;
    }
}
