using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EB3B94D8ED480F4, NameHash = 0x98B648B5C054B7F7)]
    public class GcProjectileData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour;
        /* 0x010 */ public Vector3f ImpactOffset;
        /* 0x020 */ public Colour LightColour;
        /* 0x030 */ public GcResourceElement Model;
        /* 0x2D8 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        /* 0x2E8 */ public NMSString0x10 CriticalImpact;
        /* 0x2F8 */ public NMSString0x10 DefaultImpact;
        /* 0x308 */ public NMSString0x10 Id;
        /* 0x318 */ public List<GcProjectileImpactData> Impacts;
        /* 0x328 */ public NMSString0x10 PlayerDamage;
        /* 0x338 */ public GcProjectileLineData CustomBulletData;
        // size: 0x8
        [Flags]
        public enum BehaviourFlagsEnum : uint {
            None = 0x0,
            DestroyTerrain = 0x1,
            DestroyAsteroids = 0x2,
            GatherResources = 0x4,
            Homing = 0x8,
            HomingLaser = 0x10,
            ScareCreatures = 0x20,
            ExplosionForce = 0x40,
        }
        /* 0x360 */ public BehaviourFlagsEnum BehaviourFlags;
        /* 0x364 */ public float BounceDamping;
        /* 0x368 */ public float BounceFinalStopTime;
        /* 0x36C */ public float BounceMaxSpeed;
        /* 0x370 */ public float CapsuleHeight;
        /* 0x374 */ public GcAudioWwiseEvents ChargedFireAudioEvent;
        // size: 0x4
        public enum ClassEnum : uint {
            Player,
            PlayerShip,
            Ship,
            Robot,
        }
        /* 0x378 */ public ClassEnum Class;
        /* 0x37C */ public float CriticalHitModifier;
        /* 0x380 */ public float DamageImpactMergeTime;
        /* 0x384 */ public float DamageImpactMinDistance;
        /* 0x388 */ public float DamageImpactTimeBetweenNumbers;
        /* 0x38C */ public GcDamageType DamageType;
        /* 0x390 */ public int DefaultBounces;
        /* 0x394 */ public int DefaultDamage;
        /* 0x398 */ public float DefaultSpeed;
        /* 0x39C */ public float DroneImpulse;
        /* 0x3A0 */ public float ExtraPlayerDamage;
        /* 0x3A4 */ public GcAudioWwiseEvents FireAudioEvent;
        /* 0x3A8 */ public float Gravity;
        /* 0x3AC */ public float Life;
        /* 0x3B0 */ public float Offset;
        /* 0x3B4 */ public GcAudioWwiseEvents OverheatAudioEvent;
        /* 0x3B8 */ public float PhysicsPush;
        /* 0x3BC */ public float PiercingDamagePercentage;
        /* 0x3C0 */ public float Radius;
        /* 0x3C4 */ public float RagdollPush;
        /* 0x3C8 */ public float Scale;
        /* 0x3CC */ public bool ApplyCombatLevelMultipliers;
        /* 0x3CD */ public bool HitOnBounce;
        /* 0x3CE */ public bool IsAutonomous;
        /* 0x3CF */ public bool OverrideLightColour;
        /* 0x3D0 */ public bool UseCustomBulletData;
        /* 0x3D1 */ public bool UseDamageNumberData;
    }
}
