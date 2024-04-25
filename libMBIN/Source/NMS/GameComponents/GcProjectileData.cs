using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EB3B94D8ED480F4, NameHash = 0x98B648B5C054B7F7)]
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Index = 34)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 42)]
        /* 0x010 */ public Vector3f ImpactOffset;
        [NMS(Index = 36)]
        /* 0x020 */ public Colour LightColour;
        [NMS(Index = 1)]
        /* 0x030 */ public GcResourceElement Model;
        [NMS(Index = 43)]
        /* 0x2D8 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        [NMS(Index = 40)]
        /* 0x2E8 */ public NMSString0x10 CriticalImpact;
        [NMS(Index = 39)]
        /* 0x2F8 */ public NMSString0x10 DefaultImpact;
        [NMS(Index = 0)]
        /* 0x308 */ public NMSString0x10 Id;
        [NMS(Index = 41)]
        /* 0x318 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Index = 25)]
        /* 0x328 */ public NMSString0x10 PlayerDamage;
        [NMS(Index = 29)]
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
        [NMS(Index = 37)]
        /* 0x360 */ public BehaviourFlagsEnum BehaviourFlags;
        [NMS(Index = 22)]
        /* 0x364 */ public float BounceDamping;
        [NMS(Index = 23)]
        /* 0x368 */ public float BounceFinalStopTime;
        [NMS(Index = 21)]
        /* 0x36C */ public float BounceMaxSpeed;
        [NMS(Index = 9)]
        /* 0x370 */ public float CapsuleHeight;
        [NMS(Index = 3)]
        /* 0x374 */ public GcAudioWwiseEvents ChargedFireAudioEvent;
        // size: 0x4
        public enum ClassEnum : uint {
            Player,
            PlayerShip,
            Ship,
            Robot,
        }
        [NMS(Index = 38)]
        /* 0x378 */ public ClassEnum Class;
        [NMS(Index = 26)]
        /* 0x37C */ public float CriticalHitModifier;
        [NMS(Index = 31)]
        /* 0x380 */ public float DamageImpactMergeTime;
        [NMS(Index = 33)]
        /* 0x384 */ public float DamageImpactMinDistance;
        [NMS(Index = 32)]
        /* 0x388 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 19)]
        /* 0x38C */ public GcDamageType DamageType;
        [NMS(Index = 20)]
        /* 0x390 */ public int DefaultBounces;
        [NMS(Index = 17)]
        /* 0x394 */ public int DefaultDamage;
        [NMS(Index = 10)]
        /* 0x398 */ public float DefaultSpeed;
        [NMS(Index = 16)]
        /* 0x39C */ public float DroneImpulse;
        [NMS(Index = 18)]
        /* 0x3A0 */ public float ExtraPlayerDamage;
        [NMS(Index = 2)]
        /* 0x3A4 */ public GcAudioWwiseEvents FireAudioEvent;
        [NMS(Index = 11)]
        /* 0x3A8 */ public float Gravity;
        [NMS(Index = 12)]
        /* 0x3AC */ public float Life;
        [NMS(Index = 13)]
        /* 0x3B0 */ public float Offset;
        [NMS(Index = 4)]
        /* 0x3B4 */ public GcAudioWwiseEvents OverheatAudioEvent;
        [NMS(Index = 15)]
        /* 0x3B8 */ public float PhysicsPush;
        [NMS(Index = 27)]
        /* 0x3BC */ public float PiercingDamagePercentage;
        [NMS(Index = 8)]
        /* 0x3C0 */ public float Radius;
        [NMS(Index = 14)]
        /* 0x3C4 */ public float RagdollPush;
        [NMS(Index = 5)]
        /* 0x3C8 */ public float Scale;
        [NMS(Index = 7)]
        /* 0x3CC */ public bool ApplyCombatLevelMultipliers;
        [NMS(Index = 24)]
        /* 0x3CD */ public bool HitOnBounce;
        [NMS(Index = 6)]
        /* 0x3CE */ public bool IsAutonomous;
        [NMS(Index = 35)]
        /* 0x3CF */ public bool OverrideLightColour;
        [NMS(Index = 28)]
        /* 0x3D0 */ public bool UseCustomBulletData;
        [NMS(Index = 30)]
        /* 0x3D1 */ public bool UseDamageNumberData;
    }
}
