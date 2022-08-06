using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7955FE523C1E4EFB, NameHash = 0x98B648B5C054B7F7)]
    public class GcProjectileData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents FireAudioEvent;
        /* 0x2BC */ public GcAudioWwiseEvents ChargedFireAudioEvent;
        /* 0x2C0 */ public GcAudioWwiseEvents OverheatAudioEvent;
        /* 0x2C4 */ public float Scale;
        /* 0x2C8 */ public bool IsAutonomous;
        /* 0x2C9 */ public bool ApplyCombatLevelMultipliers;
        /* 0x2CC */ public float Radius;
        /* 0x2D0 */ public float CapsuleHeight;
        /* 0x2D4 */ public float DefaultSpeed;
        /* 0x2D8 */ public float Gravity;
        /* 0x2DC */ public float Life;
        /* 0x2E0 */ public float Offset;
        /* 0x2E4 */ public float RagdollPush;
        /* 0x2E8 */ public float PhysicsPush;
        /* 0x2EC */ public float DroneImpulse;
        /* 0x2F0 */ public int DefaultDamage;
        /* 0x2F4 */ public float ExtraPlayerDamage;
        /* 0x2F8 */ public GcDamageType DamageType;
        /* 0x2FC */ public int DefaultBounces;
        /* 0x300 */ public float BounceMaxSpeed;
        /* 0x304 */ public float BounceDamping;
        /* 0x308 */ public float BounceFinalStopTime;
        /* 0x30C */ public bool HitOnBounce;
        /* 0x310 */ public NMSString0x10 PlayerDamage;
        /* 0x320 */ public float CriticalHitModifier;
        /* 0x324 */ public float PiercingDamagePercentage;
        /* 0x328 */ public bool UseCustomBulletData;
        /* 0x32C */ public GcProjectileLineData CustomBulletData;
        /* 0x354 */ public bool UseDamageNumberData;
        /* 0x358 */ public float DamageImpactMergeTime;
        /* 0x35C */ public float DamageImpactTimeBetweenNumbers;
        /* 0x360 */ public float DamageImpactMinDistance;
        /* 0x370 */ public Colour Colour;
        /* 0x380 */ public bool OverrideLightColour;
        /* 0x390 */ public Colour LightColour;
        // size: 0x8
        [Flags]
        public enum BehaviourFlagsEnum {
            None = 0x0, DestroyTerrain = 0x1, DestroyAsteroids = 0x2, GatherResources = 0x4,
            Homing = 0x8, HomingLaser = 0x10, ScareCreatures = 0x20, ExplosionForce = 0x40
        }
        [NMSDescription("The enum that describes this field uses Flags. This means that multiple values may be specified simultaneously" +
        "for example, if ValueX = 0x20, ValueY = 0x40: use the notation ''ValueX|ValueY''. Ie. split values with a | character")]
        /* 0x3A0 */ public BehaviourFlagsEnum BehaviourFlags;
        // size: 0x4
        public enum ClassEnum { Player, PlayerShip, Ship, Robot }
        /* 0x3A4 */ public ClassEnum Class;
        /* 0x3A8 */ public NMSString0x10 DefaultImpact;
        /* 0x3B8 */ public NMSString0x10 CriticalImpact;
        /* 0x3C8 */ public List<GcProjectileImpactData> Impacts;
        /* 0x3E0 */ public Vector3f ImpactOffset;
        /* 0x3F0 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
    }
}
