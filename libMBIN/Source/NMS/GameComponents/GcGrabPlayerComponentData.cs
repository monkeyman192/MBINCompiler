using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x320, GUID = 0x6D091499DCEB214D, NameHash = 0xDE6FCE33E294F619)]
    public class GcGrabPlayerComponentData : NMSTemplate
    {
        [NMS(Size = 0x100)]
        /* 0x000 */ public string LookJoint;
        [NMS(Size = 0x100)]
        /* 0x100 */ public string GrabJoint;
        [NMS(Size = 0x10)]
        /* 0x200 */ public string DefendAnim;
        [NMS(Size = 0x10)]
        /* 0x210 */ public string IdleAnim;
        [NMS(Size = 0x10)]
        /* 0x220 */ public string GrabAnim;
        [NMS(Size = 0x10)]
        /* 0x230 */ public string HoldAnim;
        [NMS(Size = 0x10)]
        /* 0x240 */ public string HitReactAnim;
        [NMS(Size = 0x10)]
        /* 0x250 */ public string PlayerGrabbedAnim;
        [NMS(Size = 0x10)]
        /* 0x260 */ public string DamageType;
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
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x31C */ public byte[] EndPadding;
    }
}
