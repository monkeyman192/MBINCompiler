using System.Collections.Generic;
using System;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3B0, GUID = 0x7207BAD0BCF5DA9A, NameHash = 0x98B648B5C054B7F7)]
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents FireAudioEvent;
        /* 0x2BC */ public GcAudioWwiseEvents OverheatAudioEvent;
        /* 0x2C0 */ public float Scale;
        /* 0x2C4 */ public bool IsAutonomous;
        /* 0x2C8 */ public float Radius;
        /* 0x2CC */ public float Speed;
        /* 0x2D0 */ public float Gravity;
        /* 0x2D4 */ public float Life;
        /* 0x2D8 */ public float Offset;
        /* 0x2DC */ public float RagdollPush;
        /* 0x2E0 */ public float PhysicsPush;
        /* 0x2E4 */ public int Damage;
        /* 0x2E8 */ public GcDamageType DamageType;
        /* 0x2EC */ public int Bounces;
        /* 0x2F0 */ public float BounceMaxSpeed;
        /* 0x2F4 */ public float BounceDamping;
        /* 0x2F8 */ public float BounceFinalStopTime;
        /* 0x2FC */ public bool HitOnBounce;
        [NMS(Size = 3, Ignore = true)]
        /* 0x2FD */ public byte[] Padding2FD;

        [NMS(Size = 0x10)]
        /* 0x300 */ public string PlayerDamage;
        /* 0x310 */ public bool UseCustomBulletData;
        /* 0x314 */ public GcProjectileLineData CustomBulletData;
        /* 0x33C */ public bool UseDamageNumberData;
        /* 0x340 */ public float DamageImpactMergeTime;
        /* 0x344 */ public float DamageImpactTimeBetweenNumbers;
        /* 0x348 */ public float DamageImpactMinDistance;
        /* 0x350 */ public Colour Colour;

        [Flags]
        public enum BehaviourFlagsEnum { None = 0x00, DestroyTerrain = 0x01, DestroyAsteroids = 0x02, GatherResources = 0x04, Homing = 0x08, HomingLaser = 0x10,
            ScareCreatures = 0x20, ExplosionForce = 0x40}
        /* 0x360 */ public BehaviourFlagsEnum BehaviourFlags;
		public enum ClassEnum { Player, PlayerShip, Ship, Robot }
		/* 0x364 */ public ClassEnum Class;
        [NMS(Size = 0x10)]
        /* 0x368 */ public string DefaultImpact;
        [NMS(Size = 0x10)]
        /* 0x378 */ public string CriticalImpact;
        /* 0x388 */ public List<GcProjectileImpactData> Impacts;
        /* 0x390 */ public Vector3f ImpactOffset;
    }
}
