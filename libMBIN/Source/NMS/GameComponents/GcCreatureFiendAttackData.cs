﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC0, GUID = 0x3A7486590D044605, NameHash = 0x41B161469E53B05E)]
    public class GcCreatureFiendAttackData : NMSTemplate
    {
        /* 0x00 */ public float NearDist;
        /* 0x04 */ public float FarDist;
        /* 0x08 */ public float ModifyDistanceForHeight;
        [NMS(Size = 0x40)]
        /* 0x0C */ public string SpitJoint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] Padding4C;
        [NMS(Size = 0x10)]
        /* 0x50 */ public string SpitProjectile;
        [NMS(Size = 0x40)]
        /* 0x60 */ public string AttackLight;
        /* 0xA0 */ public float IdleLightIntensity;
        /* 0xA4 */ public float AttackLightIntensity;
        /* 0xA8 */ public int MinFlurryHits;
        /* 0xAC */ public int MaxFlurryHits;
        /* 0xB0 */ public float RoarChanceOnHit;
        /* 0xB4 */ public float RoarChanceOnMiss;
        /* 0xB8 */ public float StartDamageTime;
        /* 0xBC */ public float TurnToFaceTime;
    }
}