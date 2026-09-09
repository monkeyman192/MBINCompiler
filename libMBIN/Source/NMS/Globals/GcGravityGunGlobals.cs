using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xF55AEC003DD948FD, NameHash = 0x8BB80F0F)]
    public class GcGravityGunGlobals : NMSTemplate
    {
        [NMS(Index = 28)]
        /* 0x000 */ public GcScanEffectData GrabHighlightEffect;
        [NMS(Index = 7)]
        /* 0x050 */ public NMSString0x10 AttachedMoveableShake;
        [NMS(Index = 45)]
        /* 0x060 */ public NMSString0x10 ImpactDamageType;
        [NMS(Index = 44)]
        /* 0x070 */ public GcImpactCombatEffectData GrabCombatEffectToTarget;
        [NMS(Index = 17)]
        /* 0x080 */ public float AngularEjectionPowerFractionOfPower;
        [NMS(Index = 6)]
        /* 0x084 */ public float AttachedMoveableAltAimLossTimeout;
        [NMS(Index = 3)]
        /* 0x088 */ public float AttachedMoveableAltEnergyRate;
        [NMS(Index = 4)]
        /* 0x08C */ public float AttachedMoveableEnergyDecayGraceTime;
        [NMS(Index = 5)]
        /* 0x090 */ public float AttachedMoveableEnergyDecayRate;
        [NMS(Index = 2)]
        /* 0x094 */ public float AttachedMoveablePrimaryEnergy;
        [NMS(Index = 8)]
        /* 0x098 */ public float AttachedMoveableShakeStrength;
        [NMS(Index = 19)]
        /* 0x09C */ public float EjectMaxPowerup;
        [NMS(Index = 18)]
        /* 0x0A0 */ public float EjectPowerupMaxTimeSeconds;
        [NMS(Index = 37)]
        /* 0x0A4 */ public float GrabDragRotationStrength;
        [NMS(Index = 35)]
        /* 0x0A8 */ public float GrabFixedRotationDampingRatio;
        [NMS(Index = 34)]
        /* 0x0AC */ public float GrabFixedRotationSpringConst;
        [NMS(Index = 36)]
        /* 0x0B0 */ public float GrabFreeRotationDampingFactor;
        [NMS(Index = 31)]
        /* 0x0B4 */ public float GrabMaxAngularSpeed;
        [NMS(Index = 30)]
        /* 0x0B8 */ public float GrabMaxLinearSpeed;
        [NMS(Index = 40)]
        /* 0x0BC */ public float GrabPositionBobMagnitude;
        [NMS(Index = 39)]
        /* 0x0C0 */ public float GrabPositionBobSpeed;
        [NMS(Index = 33)]
        /* 0x0C4 */ public float GrabPositionDampingRatio;
        [NMS(Index = 32)]
        /* 0x0C8 */ public float GrabPositionSpringConst;
        [NMS(Index = 21)]
        /* 0x0CC */ public float GrabPosOffset;
        [NMS(Index = 22)]
        /* 0x0D0 */ public float GrabPosRunningOffsetFwd;
        [NMS(Index = 23)]
        /* 0x0D4 */ public float GrabPosRunningOffsetUp;
        [NMS(Index = 24)]
        /* 0x0D8 */ public float GrabRequestTimeoutSeconds;
        [NMS(Index = 43)]
        /* 0x0DC */ public float GrabRotationBobTorqueStrength;
        [NMS(Index = 42)]
        /* 0x0E0 */ public float GrabRotationBobTorqueVariationSpeed;
        [NMS(Index = 52)]
        /* 0x0E4 */ public float ImpactAggressiveDamageMaxDamage;
        [NMS(Index = 51)]
        /* 0x0E8 */ public float ImpactAggressiveDamageMaxImpulse;
        [NMS(Index = 50)]
        /* 0x0EC */ public float ImpactAggressiveDamageMinImpulse;
        [NMS(Index = 49)]
        /* 0x0F0 */ public float ImpactDamageMaxDamage;
        [NMS(Index = 48)]
        /* 0x0F4 */ public float ImpactDamageMaxImpulse;
        [NMS(Index = 47)]
        /* 0x0F8 */ public float ImpactDamageMinImpulse;
        [NMS(Index = 53)]
        /* 0x0FC */ public float ImpactDamageModifierOnTruck;
        [NMS(Index = 46)]
        /* 0x100 */ public float ImpactDamageSpeedThreshold;
        [NMS(Index = 25)]
        /* 0x104 */ public float InitialGrabSpeed;
        [NMS(Index = 27)]
        /* 0x108 */ public float InitialGrabTimeMinSeconds;
        [NMS(Index = 9)]
        /* 0x10C */ public float PushForceUpComponent;
        [NMS(Index = 10)]
        /* 0x110 */ public float PushPower;
        [NMS(Index = 13)]
        /* 0x114 */ public float PushPowerInScrapyard;
        [NMS(Index = 11)]
        /* 0x118 */ public float PushPowerInScrapyardDistance;
        [NMS(Index = 15)]
        /* 0x11C */ public float PushPowerSentinel;
        [NMS(Index = 14)]
        /* 0x120 */ public float PushPowerSentinelEject;
        [NMS(Index = 12)]
        /* 0x124 */ public float PushPowerToxicInScrapyard;
        [NMS(Index = 16)]
        /* 0x128 */ public float ThresholdForAngularEjectionVelocity;
        [NMS(Index = 1)]
        /* 0x12C */ public int WeaponChargeGrab;
        [NMS(Index = 0)]
        /* 0x130 */ public int WeaponChargePush;
        [NMS(Index = 20)]
        /* 0x134 */ public TkCurveType EjectPowerCurve;
        [NMS(Index = 38)]
        /* 0x135 */ public bool GrabPositionBobEnabled;
        [NMS(Index = 41)]
        /* 0x136 */ public bool GrabRotationBobEnabled;
        [NMS(Index = 29)]
        /* 0x137 */ public bool GrabUseDynamicPhysics;
        [NMS(Index = 26)]
        /* 0x138 */ public TkCurveType InitialGrabCurve;
    }
}
