namespace MBINCompiler.Models.Structs
{
    public class GcShipAIAttackData : NMSTemplate       // size: 0x98
    {
        /* 0x00 */ public float AttackWeaponRange;
        /* 0x04 */ public float AttackAngle;
        /* 0x08 */ public float AttackShootWaitTime;
        /* 0x0C */ public float AttackShootTimeMin;
        /* 0x10 */ public float AttackShootTimeMax;
        /* 0x14 */ public float AttackReadyTime;
        /* 0x18 */ public float AttackMaxTime;
        /* 0x1C */ public float AttackApproachOffset;
        /* 0x20 */ public float AttackApproachMinRange;
        /* 0x24 */ public float AttackApproachMaxRange;
        /* 0x28 */ public float AttackTooCloseRange;
        /* 0x2C */ public float AttackFlybyOffset;
        /* 0x30 */ public float AttackBoostTimeToRange;
        /* 0x34 */ public float AttackBoostRange;
        /* 0x38 */ public float AttackBoostAngle;
        /* 0x3C */ public float AttackTurnMultiplier;
        /* 0x40 */ public float AttackFacingAimReducer;
        /* 0x44 */ public float AttackMaxPlanetHeight;
        /* 0x48 */ public float AttackTurnMultiplierMax;
        /* 0x4C */ public float AttackTurnMaxMinTime;
        /* 0x50 */ public float AttackTurnMaxTimeRange;
        /* 0x54 */ public int NumHitsBeforeBail;
        /* 0x58 */ public int NumHitsBeforeReposition;
        /* 0x5C */ public float FleeBrake;
        /* 0x60 */ public float FleeBoost;
        /* 0x64 */ public float FleeBrakeTime;
        /* 0x68 */ public float FleeRepositionTime;
        /* 0x6C */ public float FleeRepositionAngleMin;
        /* 0x70 */ public float FleeRepositionAngleMax;
        /* 0x74 */ public float FleeRepositionBoostTime;
        /* 0x78 */ public float FleeRange;
        /* 0x7C */ public float FleeMinTime;
        /* 0x80 */ public float FleeMaxTime;
        /* 0x84 */ public float AttackTargetMinRange;
        /* 0x88 */ public float AttackTargetMaxRange;
        /* 0x8C */ public float AttackTargetOffsetMin;
        /* 0x90 */ public float AttackTargetOffsetMax;
        /* 0x94 */ public float AttackTargetSwitchTargetTime;
    }
}
