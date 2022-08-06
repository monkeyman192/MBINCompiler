using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20CC6DC3ECD38556, NameHash = 0x1C062102935FA221)]
    public class GcPlayerSpaceshipEngineData : NMSTemplate
    {
        /* 0x00 */ public float ThrustForce;
        /* 0x04 */ public float MaxSpeed;
        /* 0x08 */ public float MinSpeed;
        /* 0x0C */ public float Falloff;
        /* 0x10 */ public float MinSpeedForce;
        /* 0x14 */ public float BoostThrustForce;
        /* 0x18 */ public float BoostMaxSpeed;
        /* 0x1C */ public float BoostFalloff;
        /* 0x20 */ public float BoostingTurnDamp;
        /* 0x24 */ public float DirectionBrakeMin;
        /* 0x28 */ public float DirectionBrake;
        /* 0x2C */ public float ReverseBrake;
        /* 0x30 */ public float OverspeedBrake;
        /* 0x34 */ public float LowSpeedTurnDamper;
        /* 0x38 */ public float TurnBrakeMin;
        /* 0x3C */ public float TurnBrakeMax;
        /* 0x40 */ public float TurnStrength;
        /* 0x44 */ public float RollAmount;
        /* 0x48 */ public float RollForce;
        /* 0x4C */ public float RollAutoTime;
        /* 0x50 */ public float BalanceTimeMin;
        /* 0x54 */ public float BalanceTimeMax;
        /* 0x58 */ public float FollowProportionalGain;
        /* 0x5C */ public float FollowDerivativeGain;
        /* 0x60 */ public float FollowIntegralGain;
        /* 0x64 */ public float FollowProportionalLimit;
        /* 0x68 */ public float FollowDerivativeLimit;
        /* 0x6C */ public float FollowIntegralLimit;
        /* 0x70 */ public float FollowIntegralDecay;
    }
}
