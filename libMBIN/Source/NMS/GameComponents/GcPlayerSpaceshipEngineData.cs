namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4064AF67E84E4AE0, NameHash = 0xD83A188)]
    public class GcPlayerSpaceshipEngineData : NMSTemplate
    {
        [NMS(Index = 21)]
        /* 0x00 */ public float BalanceTimeMax;
        [NMS(Index = 20)]
        /* 0x04 */ public float BalanceTimeMin;
        [NMS(Index = 7)]
        /* 0x08 */ public float BoostFalloff;
        [NMS(Index = 8)]
        /* 0x0C */ public float BoostingTurnDamp;
        [NMS(Index = 6)]
        /* 0x10 */ public float BoostMaxSpeed;
        [NMS(Index = 5)]
        /* 0x14 */ public float BoostThrustForce;
        [NMS(Index = 10)]
        /* 0x18 */ public float DirectionBrake;
        [NMS(Index = 9)]
        /* 0x1C */ public float DirectionBrakeMin;
        [NMS(Index = 3)]
        /* 0x20 */ public float Falloff;
        [NMS(Index = 23)]
        /* 0x24 */ public float FollowDerivativeGain;
        [NMS(Index = 26)]
        /* 0x28 */ public float FollowDerivativeLimit;
        [NMS(Index = 28)]
        /* 0x2C */ public float FollowIntegralDecay;
        [NMS(Index = 24)]
        /* 0x30 */ public float FollowIntegralGain;
        [NMS(Index = 27)]
        /* 0x34 */ public float FollowIntegralLimit;
        [NMS(Index = 22)]
        /* 0x38 */ public float FollowProportionalGain;
        [NMS(Index = 25)]
        /* 0x3C */ public float FollowProportionalLimit;
        [NMS(Index = 13)]
        /* 0x40 */ public float LowSpeedTurnDamper;
        [NMS(Index = 1)]
        /* 0x44 */ public float MaxSpeed;
        [NMS(Index = 2)]
        /* 0x48 */ public float MinSpeed;
        [NMS(Index = 4)]
        /* 0x4C */ public float MinSpeedForce;
        [NMS(Index = 12)]
        /* 0x50 */ public float OverspeedBrake;
        [NMS(Index = 11)]
        /* 0x54 */ public float ReverseBrake;
        [NMS(Index = 17)]
        /* 0x58 */ public float RollAmount;
        [NMS(Index = 19)]
        /* 0x5C */ public float RollAutoTime;
        [NMS(Index = 18)]
        /* 0x60 */ public float RollForce;
        [NMS(Index = 0)]
        /* 0x64 */ public float ThrustForce;
        [NMS(Index = 15)]
        /* 0x68 */ public float TurnBrakeMax;
        [NMS(Index = 14)]
        /* 0x6C */ public float TurnBrakeMin;
        [NMS(Index = 16)]
        /* 0x70 */ public float TurnStrength;
    }
}
